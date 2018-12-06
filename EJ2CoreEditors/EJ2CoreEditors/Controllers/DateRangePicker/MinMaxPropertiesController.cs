using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DateRangePicker
{
    public partial class DateRangePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult MinMaxProperties()
        {
            ViewBag.minDate = new DateTime(2019, 10, 22);
            ViewBag.maxDate = new DateTime(2019, 11, 25);
            return View();
        }
    }
}
