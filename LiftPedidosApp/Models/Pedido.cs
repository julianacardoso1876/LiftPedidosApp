using System.Xml.Serialization;

namespace LiftPedidosApp.Models
{
    [XmlRoot("Pedido")]
    public class Pedido
    {
        [XmlElement("Id")]
        public int Id { get; set; }

        [XmlElement("IdCliente")]
        public int IdCliente { get; set; }

        [XmlElement("Data")]
        public string Data { get; set; } = string.Empty;

        [XmlElement("ValorTotal")]
        public decimal ValorTotal { get; set; }
    }

    [XmlRoot("ArrayOfPedido")]
    public class PedidoList
    {
        [XmlElement("Pedido")]
        public List<Pedido> Pedidos { get; set; } = new();
    }
}
