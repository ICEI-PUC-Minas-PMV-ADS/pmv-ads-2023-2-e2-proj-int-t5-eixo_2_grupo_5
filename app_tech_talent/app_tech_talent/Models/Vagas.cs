using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_tech_talent.Models
{

    [Table("Vagas")]
    public class Vagas
    {
        [Key]
        public int IdVagas { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]

        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo localização é obrigatório.")]

        public string Localizacao { get; set; }

        public string formacao { get; set; }

        public string ExperienciaProficional { get; set; }

        [ForeignKey("Habilidades")]
        public int IdHabilidades { get; set; }

        public double salario { get; set; }

        [Required(ErrorMessage = "O campo localização é obrigatório.")]
        public bool status { get; set; }

        public DateTime dateTime { get; set; }

        public DateTime dataFechamento { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}

