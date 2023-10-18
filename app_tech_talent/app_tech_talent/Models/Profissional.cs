using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_tech_talent.Models
{
    [Table("Profissionais")]
    public class Profissional
    {
        [Key]
        public int ProfissionalId { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Idade é obrigatório.")]
        [Range(18, 99, ErrorMessage = "A idade deve estar entre 18 e 99 anos.")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF deve estar no formato 999.999.999-99.")]
        public string CPF { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}
