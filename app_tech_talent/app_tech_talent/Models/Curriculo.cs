using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_tech_talent.Models
{
    [Table("Curriculos")]
    public class Curriculo
    {
        [Key]
        public int IdCurriculo { get; set; }

        [Required(ErrorMessage ="Informe o resumo profissional!")]
        [Display(Name ="Resumo Profissional")]
        public string ResumoProfissional { get; set; }
    }
}
