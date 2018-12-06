using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DateRangePicker
{
    public class DateRangePostBack
    {
        public DateTime[] value { get; set; }
    }
    public partial class DateRangePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult PostBack()
        {
            var model = new DateRangePostBack();
            model.value = new DateTime[] { new DateTime(2020, 03, 03), new DateTime(2021, 09, 03) };
            return View(model);
        }
        [HttpPost]
        public IActionResult PostBack(DateRangePostBack model)
        {
            return View(model);
        }
    }
}
