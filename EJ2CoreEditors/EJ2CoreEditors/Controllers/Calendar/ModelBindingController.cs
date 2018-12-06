﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.Calendar
{
    public class CalendarModelBinding
    {
        public DateTime? value { get; set; }
    }
    public partial class CalendarController : Controller
    {
        // GET: /<controller>/
        public IActionResult ModelBinding()
        {
            var model = new CalendarModelBinding()
            {
                value = DateTime.Now
            };
            ViewBag.value = model.value;
            ViewData["value"] = model.value;
            return View();
        }
    }
}
