using Plataforma_de_Lanches.Models;

namespace Plataforma_de_Lanches.ViewModels
{
    public class PedidoLancheViewModel
    {
        public Pedido Pedido { get; set; }
        public IEnumerable<PedidoDetalhe> PedidoDetalhes { get; set; }  
    }
}
