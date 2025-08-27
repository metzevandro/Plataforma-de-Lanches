using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Plataforma_de_Lanches.Models;
using Plataforma_de_Lanches.Repository.Interfaces;

namespace Plataforma_de_Lanches.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [Authorize]
        public RedirectToActionResult AdicionarItemNoCarrinho(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p=> p.Id == lancheId);

            if(lancheSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(lancheSelecionado);
            }

            return RedirectToAction("Index");
        }

        [Authorize]
        public RedirectToActionResult RemoverItemDoCarrinho(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.Id == lancheId);
            if (lancheSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(lancheSelecionado);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();

            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new ViewModels.CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);
        }
    }
}
