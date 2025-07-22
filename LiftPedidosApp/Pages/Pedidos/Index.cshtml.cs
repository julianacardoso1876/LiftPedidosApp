using Microsoft.AspNetCore.Mvc.RazorPages;
using LiftPedidosApp.Models;
using LiftPedidosApp.Services;

namespace LiftPedidosApp.Pages.Pedidos
{
    public class IndexModel : PageModel
    {
        private readonly ApiService _api;

        public IndexModel(ApiService api)
        {
            _api = api;
        }

        public List<Pedido> Pedidos { get; set; } = new();
        public Dictionary<int, string> Clientes { get; set; } = new();

        public async Task OnGetAsync()
        {
            Pedidos = await _api.GetPedidosAsync();
            var listaClientes = await _api.GetClientesAsync();
            Clientes = listaClientes.ToDictionary(c => c.Id, c => c.Nome);
        }
    }
}