using Microsoft.AspNetCore.Mvc;

namespace Doodle_Forms.Controllers
{
    public class FormFillingOutController : Controller
    {
        [HttpGet] public IActionResult FillOutForm() => View();
        [HttpGet] public IActionResult EnterFormLink() => View();
    }
}
