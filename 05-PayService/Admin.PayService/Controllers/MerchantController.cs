﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Admin.PayService.Controllers
{
    public class MerchantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}