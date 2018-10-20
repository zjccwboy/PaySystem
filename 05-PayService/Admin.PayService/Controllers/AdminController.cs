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
using Admin.DTO;

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

        public IActionResult AdminList()
        {
            return View();
        }

        public async Task<IActionResult> CreateAdmin(RequestModel<CreateAdminModel> model)
        {
            var result = new ResponseModel{ ResultCode = (int)ResultCode.UnknownError};
            if(string.IsNullOrWhiteSpace(model.Body.UserName))
            {
                result.ResultCode = (int)AccountResultCode.UserNameNotNull;
                result.Message = "用户名不能为空";
                return Json(result);
            }
            if(model.Body.UserName.Length > 20)
            {
                result.ResultCode = (int)AccountResultCode.UserNameOutLength;
                result.Message = "用户名不能超过20个字符串";
                return Json(result);
            }
            if(string.IsNullOrWhiteSpace(model.Body.Password))
            {
                result.ResultCode = (int)AccountResultCode.PasswordNotNull;
                result.Message = "密码不能为空";
                return Json(result);
            }
            if(model.Body.Password.Length < 8)
            {
                result.ResultCode = (int)AccountResultCode.PasswordTooShort;
                result.Message = "密码不能小于8位";
                return Json(result);
            }
            if(model.Body.Password.Length > 32)
            {
                result.ResultCode = (int)AccountResultCode.PasswordOutLength;
                result.Message = "密码不超过32位";
                return Json(result);
            }
            var bllResult = await this.AccountManagerBll.CreateAdmin(new CreateAdminInput
            {
                Model = model.Body,
                Result = result
            });
            return Json(bllResult.Result);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StartLogin(RequestModel<AdminLoginModel> model)
        {
            var result = new ResponseModel { ResultCode = (int)ResultCode.UnknownError };
            await Task.CompletedTask;
            if (string.IsNullOrWhiteSpace(model.Body.UserName))
            {
                result.ResultCode = (int)AccountResultCode.UserNameNotNull;
                result.Message = "用户名不能为空";
                return Json(result);
            }
            if (string.IsNullOrWhiteSpace(model.Body.Password))
            {
                result.ResultCode = (int)AccountResultCode.PasswordNotNull;
                result.Message = "密码不能为空";
                return Json(result);
            }
            var bllResult = await this.AccountManagerBll.AdminLogin(new AdminLoginInput
            {
                Model = model.Body,
                LoginIP = this.GetUserIp(),
                Result = result,
            });
            return Json(bllResult.Result);
        }
    }
}