using System.Xml.Serialization;

namespace LiftPedidosApp.Models
{
    [XmlRoot("ItemPedido")]
    public class ItemPedido
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("idPedido")]
        public int IdPedido { get; set; }

        [XmlElement("idProduto")]
        public int IdProduto { get; set; }

        [XmlElement("quantidade")]
        public int Quantidade { get; set; }

        [XmlElement("valorUnitario")]
        public decimal ValorUnitario { get; set; }
    }
}
