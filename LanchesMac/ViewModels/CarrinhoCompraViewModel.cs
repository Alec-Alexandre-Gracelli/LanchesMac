using LanchesMac.Models;

namespace LanchesMac.ViewModels
{
    public class CarrinhoCompraViewModel
    {
        public CarrinhoCompraViewModel CarrinhoCompra { get; set; }
        public decimal CarrinhoCompraTotal { get; set; }

        public static implicit operator CarrinhoCompraViewModel(CarrinhoCompra v)
        {
            throw new NotImplementedException();
        }
    }
}
