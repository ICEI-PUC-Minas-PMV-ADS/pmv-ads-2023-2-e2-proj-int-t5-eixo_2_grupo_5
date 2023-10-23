using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_tech_talent.Models
{
    [Table("ExperienciaProfissional")]
    public class ExperienciaProfissional
    {
        [Key]
        public int IdExperienciaProfissional { get; set; }

        [ForeignKey("Curriculo")]
        public int IdCurriculo { get; set; }

        [StringLength(100, ErrorMessage = "A Empresa deve ter no máximo 100 caracteres.")]
        public string Empresa { get; set; }

        [StringLength(100, ErrorMessage = "O Cargo deve ter no máximo 100 caracteres.")]
        public string Cargo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataDeInicio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataDeTermino { get; set; }
        
        [StringLength(500, ErrorMessage = "A Resumo da Atuação deve ter no máximo 500 caracteres.")]
        public string ResumoDaAtuacao { get; set; }
    }
}
