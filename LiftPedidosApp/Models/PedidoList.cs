using System.Collections.Generic;
using System.Xml.Serialization;

namespace LiftPedidosApp.Models
{
    [XmlRoot("ArrayOfPedido")]
    public class PedidoList
    {
        [XmlElement("Pedido")]
        public List<Pedido> Pedidos { get; set; } = new();
    }
}
