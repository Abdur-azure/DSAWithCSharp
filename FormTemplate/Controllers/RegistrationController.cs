using FormTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormTemplate.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationUser _auc;

        public RegistrationController(ApplicationUser auc)
        {
            _auc = auc;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(UserReg uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = "The user " + uc.Username + " is save succesfully";
            return View();
        }
    }
}
