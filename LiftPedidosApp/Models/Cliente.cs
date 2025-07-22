using System.Xml.Serialization;

namespace LiftPedidosApp.Models
{
    [XmlRoot("Cliente")]
    public class Cliente
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("nome")]
        public string Nome { get; set; } = string.Empty;

        [XmlElement("cpf")]
        public string Cpf { get; set; } = string.Empty;

        [XmlElement("email")]
        public string Email { get; set; } = string.Empty;
    }
}
