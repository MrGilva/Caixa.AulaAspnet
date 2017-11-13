using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Caixa.AulaAspnet.Entidades.Modelos
{
    public class Telefone
    {
        [Key]
        public int TelefoneId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Ddd { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }

        //[DataType(DataType.DateTime, ErrorMessage = "Data Inválida")]
        //public DateTime Data { get; set; }

        //[DataType(DataType.EmailAddress, ErrorMessage = "Email Inválido")]
        //public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [ForeignKey("TipoTelefone")]
        public int IdTipoTelefone { get; set; }

        public virtual TipoTelefone TipoTelefone { get; set; }
    }
}
