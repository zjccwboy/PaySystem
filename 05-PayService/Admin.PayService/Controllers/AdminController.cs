using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.PayModel;
using Admin.PayService.Models;
using Base.Common.Enums;
using Microsoft.AspNetCore.Mvc;
using Admin.PayBll;
using Base.PayBll;
using Base.WebCore.MVC;

namespace Admin.PayService.Controllers
{
    public class AdminController : MVCController
    {
        private AccountManagerBll AccountManagerBll { get; }

        public AdminController()
        {
            this.AccountManagerBll = PayBllFactory.Create<AccountManagerBll>();
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<CreateAccountResultModel> CreateAdmin(CreateAdminModel model)
        {
            var result = new CreateAccountResultModel { ResultCode = (int)ResultCode.UnKnowError };
            if(string.IsNullOrWhiteSpace(model.UserName))
            {
                result.ResultCode = (int)AdminResultCode.UserNameNotNull;
                return result;
            }
            if(model.UserName.Length > 20)
            {
                result.ResultCode = (int)AdminResultCode.UserNameOutLength;
                return result;
            }
            if(string.IsNullOrWhiteSpace(model.Password))
            {
                result.ResultCode = (int)AdminResultCode.PasswordNotNull;
                return result;
            }
            if(model.Password.Length < 8)
            {
                result.ResultCode = (int)AdminResultCode.PasswordTooShort;
                return result;
            }
            if(model.Password.Length > 32)
            {
                result.ResultCode = (int)AdminResultCode.PasswordOutLength;
                return result;
            }
            var resultCode = await this.AccountManagerBll.AddAdmin(model);
            result.ResultCode = (int)resultCode;
            return result;
        }

    }
}