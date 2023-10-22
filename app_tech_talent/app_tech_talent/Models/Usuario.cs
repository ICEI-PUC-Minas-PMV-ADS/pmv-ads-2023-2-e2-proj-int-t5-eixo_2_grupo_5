using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_tech_talent.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Informe um endereço de e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Tipo de Usuário")]
        public TipoUsuario TipoUsuario { get; set; }

        public string RecoveryKey { get; set; }
    }

    public enum TipoUsuario
    {
        Empresa,
        Profissional
    }
}
