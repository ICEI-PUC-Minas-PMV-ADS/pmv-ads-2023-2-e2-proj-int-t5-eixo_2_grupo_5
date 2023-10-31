using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_tech_talent.Models
{
    [Table("Curriculo")]
    public class Curriculo
    {
        [Key]
        public int IdCurriculo { get; set; }

        [ForeignKey("Profissional")]
        public string CPF { get; set; }

        [StringLength(500, ErrorMessage = "O Resumo Profissional deve ter no máximo 500 caracteres.")]
        [Display(Name = "Resumo Profissional")]
        public string ResumoProfissional { get; set; }
    }
}
