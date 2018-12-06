using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DateTimePicker
{
    public partial class DateTimePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Globalization()
        {
            ViewBag.minDate = new DateTime(2018, 12, 05, 0, 0, 0);
            ViewBag.maxDate = new DateTime(2018, 12, 25, 2, 30, 0);
            return View();
        }
    }
}
