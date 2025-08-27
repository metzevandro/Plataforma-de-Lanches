using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Plataforma_de_Lanches.Models;
using Plataforma_de_Lanches.Repository.Interfaces;

namespace Plataforma_de_Lanches.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILogger<HomeController> logger, ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new ViewModels.HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };

            return View(homeViewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
