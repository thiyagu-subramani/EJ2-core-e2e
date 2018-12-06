﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.TimePicker
{
    public partial class TimePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult MinMaxProperties()
        {
            ViewBag.minDate = new DateTime(2017, 05, 07, 02, 00, 00);
            ViewBag.maxDate = new DateTime(2017, 05, 07, 09, 00, 00);
            return View();
        }
    }
}
