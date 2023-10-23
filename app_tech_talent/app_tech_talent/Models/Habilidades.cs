using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_tech_talent.Models
{
    [Table("Habilidades")]
    public class Habilidades
    {
        [Key]
        public int IdHabilidades { get; set; }
        
        [ForeignKey("Profissional")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "É obrigatório selecionar uma opção.")]
        public bool Ingles { get; set; }

        [Required(ErrorMessage = "É obrigatório selecionar uma opção.")]
        public bool Programacao { get; set; }

        [Required(ErrorMessage = "É obrigatório selecionar uma opção.")]
        public bool BancoDeDados { get; set; }

        [Required(ErrorMessage = "É obrigatório selecionar uma opção.")]
        public bool AnaliseDeDados { get; set; }

        [Required(ErrorMessage = "É obrigatório selecionar uma opção.")]
        public bool MachineLearningEInteligenciaArtificial { get; set; }

        [Required(ErrorMessage = "É obrigatório selecionar uma opção.")]
        public bool DesignDeInterfacesDeUsuario { get; set; }

        [Required(ErrorMessage = "É obrigatório selecionar uma opção.")]
        public bool DesignDeExperienciaDeUsuario { get; set; }

        [Required(ErrorMessage = "É obrigatório selecionar uma opção.")]
        public bool DevOps { get; set; }
    }
}
