using Admin.PayModel;
using Base.Common.Enums;
using Base.Common.Utils;
using Base.PayBll;
using Base.Rpository;
using Microsoft.EntityFrameworkCore;
using PayEntities;
using PaySys.Rpository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Admin.DTO;

namespace Admin.PayBll
{
    public class AccountManagerBll : BasePayBll
    {
        private AccountRpository AccountRpository { get; } = RpositoryFactory.Create<AccountRpository>();
        private AdminRpository AdminRpository { get; } = RpositoryFactory.Create<AdminRpository>();
        private CustomerRpository CustomerRpository { get; } = RpositoryFactory.Create<CustomerRpository>();
        private AdminLoginLogRpository AdminLoginLogRpository { get; } = RpositoryFactory.Create<AdminLoginLogRpository>();

        public async Task<CreateAdminOutput> CreateAdmin(CreateAdminInput dto)
        {
            var output = new CreateAdminOutput { Result = dto.Result};
            if (await this.AccountRpository.ExistedAsync(dto.Model.UserName))
            {
                output.Result.ResultCode = (int)AccountResultCode.UserNameExisted;
                output.Result.Message = "该用户名存在";
                return output;
            }
            var account = new TAccount
            {
                Name = dto.Model.UserName,
                Password = dto.Model.Password,
                Type = dto.Model.AccountType,
                Emai = dto.Model.Email,
            };
            account.SetCreator(1);
            account.SetUpdater(1);
            await this.AccountRpository.AddAsync(account);
            var amax = await this.AdminRpository.GetMaxJobNumber();
            var cmax = await this.CustomerRpository.GetMaxJobNumber();
            var admin = new TAdmin
            {
                AccountId = account.Id,
                JobNumber = JobNumberUtils.GetJobNumber(amax, cmax),
            };
            admin.SetCreator(1);
            admin.SetUpdater(1);
            await this.AdminRpository.AddAsync(admin);
            if (!await this.SaveChangesAsync())
            {
                output.Result.Message = "数据保存失败";
                return output;
            }
            output.Result.ResultCode = (int)ResultCode.Successful;
            return output;
        }

        public async Task<AdminLoginOutput> AdminLogin(AdminLoginInput dto)
        {
            var output = new AdminLoginOutput { Result = dto.Result };
            if (!await this.AccountRpository.ExistedAsync(dto.Model.UserName))
            {
                output.Result.ResultCode = (int)AccountResultCode.UserNotExist;
                output.Result.Message = "用户不存在";
                return output;
            }

            var accounts = this.DbContext.TAccount
                .Where(a=>a.Type == AccountType.Admin)
                .Where(a => a.Name == dto.Model.UserName)
                .Join(this.DbContext.TAdmin, m => m.Id, f => f.AccountId, (m, f) =>
                    new
                    {
                        m.Id,
                        m.Password,
                        m.Name,
                        m.Type,
                        f.JobNumber,
                    }
                );

            var account = await accounts.FirstOrDefaultAsync();
            if (!dto.Model.Password.Equals(account.Password))
            {
                output.Result.ResultCode = (int)AccountResultCode.PasswordError;
                output.Result.Message = "密码错误";
                return output;
            }

            var admin = await this.AdminRpository.GetAdmin(account.Id);
            await this.AdminRpository.SetLoginInfo(account.Id, dto.LoginIP, admin);

            //写登陆日志
            var loginLog = new TAdminLoginLog
            {
                AccountId = admin.AccountId,
                LoginIp = dto.LoginIP,
            };
            await AdminLoginLogRpository.AddAsync(loginLog);

            if (!await this.SaveChangesAsync())
                return output;

            output.Result.ResultCode = (int)ResultCode.Successful;
            return output;
        }
    }
}
