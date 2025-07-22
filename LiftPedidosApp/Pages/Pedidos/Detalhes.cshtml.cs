using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LiftPedidosApp.Models;
using LiftPedidosApp.Services;

namespace LiftPedidosApp.Pages.Pedidos
{
    public class DetalhesModel : PageModel
    {
        private readonly ApiService _api;

        public DetalhesModel(ApiService api)
        {
            _api = api;
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public Pedido? Pedido { get; set; }
        public Cliente? Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; } = new();
        public List<Produto> Produtos { get; set; } = new();

        public async Task<IActionResult> OnGetAsync()
        {
            Pedido = await _api.GetPedidoByIdAsync(Id);
            if (Pedido == null) return NotFound();

            Cliente = await _api.GetClienteByIdAsync(Pedido.IdCliente);
            Itens = await _api.GetItensPedidoAsync(Id);
            Produtos = await _api.GetProdutosAsync();

            return Page();
        }
    }
}