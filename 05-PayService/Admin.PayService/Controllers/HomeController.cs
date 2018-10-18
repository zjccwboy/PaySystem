using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Base.WebCore.MVC;
using Microsoft.AspNetCore.Mvc;

namespace Admin.PayService.Controllers
{
    public class HomeController : MVCController
    {
        public IActionResult Index()
        {
            return Redirect("admin/index");
        }
    }
}