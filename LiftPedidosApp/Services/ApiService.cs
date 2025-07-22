using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using LiftPedidosApp.Models;

namespace LiftPedidosApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _client;
        private readonly string baseUrl = "https://sistemalift1.com.br/lift_ps/api";

        public ApiService(HttpClient client)
        {
            _client = client;
        }

        // Método genérico para obter XML e desserializar
        private async Task<T> GetXmlAsync<T>(string endpoint)
        {
            var response = await _client.GetAsync(baseUrl + endpoint);
            response.EnsureSuccessStatusCode();

            var xml = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"[XML] {endpoint}: {xml}");

            if (xml.Contains("<script") || xml.Contains("<html"))
                throw new InvalidDataException("A resposta da API não é XML válido.");

            var serializer = new XmlSerializer(typeof(T));
            using var reader = new StringReader(xml);
            return (T)serializer.Deserialize(reader)!;
        }

        // Clientes (lista em XML)
        public async Task<List<Cliente>> GetClientesAsync()
        {
            var clienteList = await GetXmlAsync<ClienteList>("/Clientes");
            return clienteList.Clientes;
        }

        // Cliente por ID (XML)
        public Task<Cliente> GetClienteByIdAsync(int id) => GetXmlAsync<Cliente>($"/Clientes/{id}");

        // Pedidos (lista em XML)
        public async Task<List<Pedido>> GetPedidosAsync()
        {
            var pedidoList = await GetXmlAsync<PedidoList>("/Pedidos");
            return pedidoList.Pedidos;
        }

        // Pedido por ID (XML)
        public Task<Pedido> GetPedidoByIdAsync(int id) => GetXmlAsync<Pedido>($"/Pedidos/{id}");

        // Itens do Pedido (lista em XML)
        public async Task<List<ItemPedido>> GetItensPedidoAsync(int pedidoId)
        {
            var itemList = await GetXmlAsync<ItemPedidoList>($"/ItensPedido/{pedidoId}");
            return itemList.Itens;
        }

        // Produtos (lista em XML)
        public async Task<List<Produto>> GetProdutosAsync()
        {
            var produtoList = await GetXmlAsync<ProdutoList>("/Produtos");
            return produtoList.Produtos;
        }

        // Produto por ID (XML)
        public Task<Produto> GetProdutoByIdAsync(int id) => GetXmlAsync<Produto>($"/Produtos/{id}");
    }
}




