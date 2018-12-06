using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DateRangePicker
{
    public class DateRangeValue
    {
        [Required(ErrorMessage = "Please enter the value")]
        public DateTime[] value { get; set; }

    }
    public partial class DateRangePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult DateRangePickerFor()
        {
            DateRangeValue val = new DateRangeValue();
            val.value = new DateTime[] { new DateTime(2020, 03, 03), new DateTime(2021, 09, 03) };
            return View(val);
        }
        [HttpPost]
        public IActionResult DateRangePickerFor(DateRangeValue model)
        {
            DateRangeValue val = new DateRangeValue();
            val.value = model.value;
            return View(val);
        }
    }
}
