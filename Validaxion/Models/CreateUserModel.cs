using System.ComponentModel.DataAnnotations;

namespace Validaxion.Models
{
    public class CreateUserModel
    {
        [Required(ErrorMessage ="O Usuario e Obrigatorio")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Nome Deve Conter Entre 3 e 10 Caracteres")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Senha Obrigatorio")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Salario Obrigatorio")]
        [Range(0,999.99, ErrorMessage = "Voce Ganha Muito")]
        public decimal Salary { get; set; }
        [Required(ErrorMessage = "E-mail Obrigatorio")]
        [EmailAddress(ErrorMessage = "E-mail Invalido")]
        [EmailInUseAttribute]
        [BlockDomainAttribute("gmail.com")]
        public string Email { get; set; }
    }
}
