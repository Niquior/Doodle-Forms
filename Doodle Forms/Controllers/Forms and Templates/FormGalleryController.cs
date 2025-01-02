using Microsoft.AspNetCore.Mvc;

namespace Doodle_Forms.Controllers
{
    public class FormGalleryController : Controller 
    {
        [HttpGet] public IActionResult ViewFormsGallery() => View();
    }
}
