using Doodle_Forms.Migrations;
using Doodle_Forms.Models.Account;
using Doodle_Forms.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Doodle_Forms.Controllers
{
    public class AccountController(ApplicationDbContext context) : Controller
    {
        private readonly ApplicationDbContext _context = context;

        [HttpGet] public IActionResult Register() => View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            if (_context.Users.Any(user => user.Email == model.Email))
            {
                ModelState.AddModelError("", "User with this Email already exists.");
                return View(model);
            }

            _context.Users.Add(new User(model.Name, model.Email, model.Password, model.IsAdmin));
            await _context.SaveChangesAsync();

            return RedirectToAction("Login");
        }

        [HttpGet] public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(LoginUserViewModel model)
        {
            var user = _context.Users.FirstOrDefault(user => user.Email == model.Email);

            if (user is null || user.PasswordHash.ToUpper() != new Hash(model.Password, user.Salt).ToString())
            {
                ModelState.AddModelError("", "Incorrect Email or Password");
                return View();
            }

            HttpContext.Session.SetInt32("UserId", user.Id);
            HttpContext.Session.SetString("UserName", user.Name);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
