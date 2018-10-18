using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.PayModel;
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

        public async Task<JsonResult> CreateAdmin(RequestModel<CreateAdminModel> model)
        {
            var result = new ResponseModel{ ResultCode = (int)ResultCode.UnKnowError };
            if(string.IsNullOrWhiteSpace(model.Body.UserName))
            {
                result.ResultCode = (int)AdminResultCode.UserNameNotNull;
                result.Message = "用户名不能为空";
                return Json(result);
            }
            if(model.Body.UserName.Length > 20)
            {
                result.ResultCode = (int)AdminResultCode.UserNameOutLength;
                result.Message = "用户名不能超过20个字符串";
                return Json(result);
            }
            if(string.IsNullOrWhiteSpace(model.Body.Password))
            {
                result.ResultCode = (int)AdminResultCode.PasswordNotNull;
                result.Message = "密码不能为空";
                return Json(result);
            }
            if(model.Body.Password.Length < 8)
            {
                result.ResultCode = (int)AdminResultCode.PasswordTooShort;
                result.Message = "密码不能小于8位";
                return Json(result);
            }
            if(model.Body.Password.Length > 32)
            {
                result.ResultCode = (int)AdminResultCode.PasswordOutLength;
                result.Message = "密码不超过32位";
                return Json(result);
            }
            var resultCode = await this.AccountManagerBll.AddAdmin(model.Body);
            result.ResultCode = (int)resultCode;
            return Json(result);
        }

    }
}