using Microsoft.AspNetCore.Mvc;

namespace Doodle_Forms.Controllers
{
    public class TemplateCreatingController : Controller
    {
        [HttpGet] public IActionResult CreateTemplate() => View();
    }
}
