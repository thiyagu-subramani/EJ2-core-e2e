using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DatePicker
{
    public partial class DatePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Globalization()
        {
            ViewBag.minDate = new DateTime(2018, 12, 05);
            ViewBag.maxDate = new DateTime(2018, 12, 25);
            return View();
        }
    }
}
