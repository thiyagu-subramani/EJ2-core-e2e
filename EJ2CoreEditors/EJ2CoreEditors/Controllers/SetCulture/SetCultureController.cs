﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.SetCulture
{
    public partial class SetCultureController : Controller
    {
        // GET: /<controller>/
        public IActionResult SetCulture()
        {
            ViewBag.value = new DateTime(2017, 08, 03);
            ViewBag.startDate = new DateTime(2017, 11, 09);
            ViewBag.endDate = new DateTime(2017, 11, 21);
            return View();
        }
    }
}
