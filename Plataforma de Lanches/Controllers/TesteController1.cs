using Microsoft.AspNetCore.Mvc;

namespace Plataforma_de_Lanches.Controllers
{
    public class TesteController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}
