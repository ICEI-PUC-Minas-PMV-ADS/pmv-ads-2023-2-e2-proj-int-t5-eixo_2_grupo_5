
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace app_tech_talent.Models
{
    [Table("Candidaturas")]
    public class Candidatura
    {
        [Key]
        public int CandidaturaId { get; set; }

        [ForeignKey("Profissional")]
        public int ProfissionalId { get; set; }

        [ForeignKey("Vaga")]
        public int VagaId{ get; set; }

        public Status Status { get; set; }
    }

    public enum Status
    {
        Enviada,
        EmAnalise,
        Aceita,
        Rejeitada
    }

}

