using System.ComponentModel.DataAnnotations;

namespace ProjetoSite1.ViewModel
{
    public class CadastroUsuarioViewModel
    {
        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Digite seu nome")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Digite seu sobrenome")]        
        public string LastNameUser { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é necessária")]
        [Display(Name = "Digite sua senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "A senha é necessária")]
        [Display(Name = "Digite sua senha")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas são diferentes")]
        public string ConfirmPassword { get; set; }

        public string ReturnUrl { get; set; }

    }

    public class LoginUsuarioViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é necessária")]
        [Display(Name = "Digite sua senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
