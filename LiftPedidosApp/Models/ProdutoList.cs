using System.Collections.Generic;
using System.Xml.Serialization;

namespace LiftPedidosApp.Models
{
    [XmlRoot("ArrayOfProduto")]
    public class ProdutoList
    {
        [XmlElement("Produto")]
        public List<Produto> Produtos { get; set; } = new();
    }
}
