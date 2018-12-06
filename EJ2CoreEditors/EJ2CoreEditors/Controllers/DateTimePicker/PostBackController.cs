using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DateTimePicker
{
    public class DateTimePickerPostBack
    {
        public DateTime? value { get; set; }
    }
    public partial class DateTimePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult PostBack()
        {
            var model = new DateTimePickerPostBack();
            model.value = new DateTime(2019, 11, 02, 12, 00, 00);
            return View(model);
        }
        [HttpPost]
        public IActionResult PostBack(DateTimePickerPostBack model)
        {
            return View(model);
        }
    }
}
