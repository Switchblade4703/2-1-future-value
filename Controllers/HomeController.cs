using Microsoft.AspNetCore.Mvc;
using _2_1.Models;

namespace _2_1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult index()
        {
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
           else 
            { 
                ViewBag.FV = 0; 
            }
            return View(model);
        }
    }
}
