using System.Xml.Serialization;

namespace LiftPedidosApp.Models
{
    [XmlRoot("Produto")]
    public class Produto
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("nome")]
        public string Nome { get; set; } = string.Empty;

        [XmlElement("preco")]
        public decimal Preco { get; set; }
    }
}
