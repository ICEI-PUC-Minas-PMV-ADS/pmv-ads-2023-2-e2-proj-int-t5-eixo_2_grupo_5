using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_tech_talent.Models
{
    [Table("FormacaoAcademica")]
    public class FormacaoAcademica
    {
        [Key]
        public int IdFormacaoAcademica { get; set; }

        [ForeignKey("Curriculo")]
        public int IdCurriculo { get; set; }

        [StringLength(100, ErrorMessage = "A Instituição de Ensino deve ter no máximo 100 caracteres.")]
        [Display(Name = "Instituição de ensino")]
        public string InstituicaoDeEnsino { get; set; }

        [StringLength(100, ErrorMessage = "O Grau Obtido deve ter no máximo 100 caracteres.")]
        [Display(Name = "Grau obtido")]
        public string grauObtido { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ano de conclusão")]
        public DateTime AnoDeConclusao { get; set; }

        [StringLength(200, ErrorMessage = "A Área de Estudo deve ter no máximo 200 caracteres.")]
        [Display(Name = "Área de estudo")]
        public string AreaDeEstudo { get; set; }
    }
}