using Microsoft.AspNetCore.Mvc;

namespace Control_Vista.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
        public IActionResult Depositar()
        {
            return View();
        }

        public IActionResult Dispensacion() 
        {
            return View();
        }

        public IActionResult Consultar()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
