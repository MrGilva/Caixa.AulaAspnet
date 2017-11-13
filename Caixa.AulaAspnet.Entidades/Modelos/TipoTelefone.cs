using System.ComponentModel.DataAnnotations;

namespace Caixa.AulaAspnet.Entidades.Modelos
{
    public class TipoTelefone
    {
        [Key]
        public int TipoTelefoneID { get; set; }

        [Display(Name = "Tipo de Telefone")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(12, ErrorMessage = "Máximo de Caracter Permitido: 12")]
        [MinLength(2, ErrorMessage = "Mínimo de Caracter Permitido: 2")]
        public string Descricao { get; set; }
    }
}
