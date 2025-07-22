using System.Collections.Generic;
using System.Xml.Serialization;

namespace LiftPedidosApp.Models
{
    [XmlRoot("ArrayOfItemPedido")]
    public class ItemPedidoList
    {
        [XmlElement("ItemPedido")]
        public List<ItemPedido> Itens { get; set; } = new();
    }
}
