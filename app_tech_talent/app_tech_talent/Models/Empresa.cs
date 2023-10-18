using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_tech_talent.Models
{
    [Table("Empresas")]
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }

        [Required(ErrorMessage = "O campo RazaoSocial é obrigatório.")]
        [StringLength(100, ErrorMessage = "A Razão Social deve ter no máximo 100 caracteres.")]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O campo CNPJ é obrigatório.")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}-\d{2}$", ErrorMessage = "O CNPJ deve estar no formato 99.999.999/9999-99.")]
        public string CNPJ { get; set; }

        [StringLength(100, ErrorMessage = "O Logradouro deve ter no máximo 100 caracteres.")]
        public string Logradouro { get; set; }

        [StringLength(2, ErrorMessage = "UF deve ter 2 caracteres.")]
        public string UF { get; set; }

        [StringLength(8, ErrorMessage = "CEP deve ter no máximo 8 caracteres.")]
        public string CEP { get; set; }

        [StringLength(100, ErrorMessage = "O Bairro deve ter no máximo 100 caracteres.")]
        public string Bairro { get; set; }

        [StringLength(100, ErrorMessage = "A Cidade deve ter no máximo 100 caracteres.")]
        public string Cidade { get; set; }

        [Url(ErrorMessage = "O Website não é uma URL válida.")]
        [Display(Name = "Website")]
        public string WebSite { get; set; }

        [StringLength(500, ErrorMessage = "A Descrição deve ter no máximo 500 caracteres.")]
        public string Descricao { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }

}
