using System.Collections.Generic;
using System.Xml.Serialization;

namespace LiftPedidosApp.Models
{
    [XmlRoot("ArrayOfCliente")]
    public class ClienteList
    {
        [XmlElement("Cliente")]
        public List<Cliente> Clientes { get; set; } = new();
    }
}
