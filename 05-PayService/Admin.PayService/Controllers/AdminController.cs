using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.PayModel;
using Admin.PayService.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin.PayService.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public Task<CreateAccountResultModel> CreateAccount(CreateAccountModel model)
        {

        }



    }
}