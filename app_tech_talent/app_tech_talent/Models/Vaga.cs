using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_tech_talent.Models
{

    [Table("Vagas")]
    public class Vaga
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        [Display(Name = "Título da vaga")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo localização é obrigatório.")]
        [Display(Name = "Localização")]
        public string Localizacao { get; set; }

        [Display(Name = "Formação")]
        public string formacao { get; set; }

        [Display(Name = "Experiência Profissional")]
        public string ExperienciaProficional { get; set; }

        [Display(Name = "Habilidades desejadas")]
        public string Habilidades { get; set; }

        [Display(Name = "Salário")]
        public double salario { get; set; }

        [Required(ErrorMessage = "O campo de status é obrigatório.")]
        [Display(Name = "Vaga disponível de imediato?")]
        public bool status { get; set; }

        [Display(Name = "Data de abetura")]
        public DateTime dateAbertura { get; set; }

        [Display(Name = "Data de fechamento")]
        public DateTime dataFechamento { get; set; }

        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }


    }
}