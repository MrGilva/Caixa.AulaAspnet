using System.ComponentModel.DataAnnotations;

namespace Caixa.AulaAspnet.Entidades.Modelos
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteID { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
    }
}
