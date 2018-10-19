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

namespace Admin.PayBll
{
    public class AccountManagerBll : BasePayBll
    {
        private AccountRpository AccountRpository { get; }
        private AdminRpository AdminRpository { get; }
        private CustomerRpository CustomerRpository { get; }

        public AccountManagerBll()
        {
            this.AccountRpository = RpositoryFactory.Create<AccountRpository>();
            this.AdminRpository = RpositoryFactory.Create<AdminRpository>();
            this.CustomerRpository = RpositoryFactory.Create<CustomerRpository>();
        }

        public async Task<int> AddAdmin(CreateAdminModel model)
        {
            var result = (int)ResultCode.UnKnowError;
            if(await this.AccountRpository.ExistedAsync(model.UserName))
            {
                result = (int)AdminResultCode.UserNameExisted;
                return result;
            }

            var account = new TAccount
            {
                Fname = model.UserName,
                Fpassword = model.Password,
                Ftype = model.AccountType,
                Femai = model.Email,
            };
            account.SetCreator(1);
            account.SetUpdater(1);

            await this.AccountRpository.AddAsync(account);            

            var amax = await this.AdminRpository.GetMaxJobNumber();
            var cmax = await this.CustomerRpository.GetMaxJobNumber();
            var admin = new TAdmin
            {
                FaccountId = account.Id,
                FjobNumber = JobNumberUtils.GetJobNumber(amax, cmax),
            };
            admin.SetCreator(1);
            admin.SetUpdater(1);
            await this.AdminRpository.AddAsync(admin);

            if (await this.DbContext.SaveChangesAsync() <= 0)
                return result;

            result = (int)ResultCode.Successful;
            return result;
        }
    }
}
