using System.ComponentModel.DataAnnotations;

namespace ProjetoSite1.Models
{
    public class UsuarioModel
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Informe o nome do Usuario.")]
        [MaxLength(50, ErrorMessage = "O nome deve conter menos de 50 caracteres")]
        [Display(Name = "Informe o nome do Usuario")]
        public string UsuarioNome { get; set; }

        
        [Required(ErrorMessage = "Informe o Sobrenome do Usuario.")]
        [MaxLength(70, ErrorMessage = "O nome deve conter menos de 70 caracteres")]
        [Display(Name = "Informe o Sobrenome do Usuario.")]
        public string UsuarioSobrenome { get; set; }

        [Required(ErrorMessage = "Informe o Nick do usuario.")]
        [RegularExpression(@"^([a-zA-Z](?:(?:(?:\w[\.]?)*)\w)+)([a-zA-Z0-9])$", ErrorMessage = "O Nick está fora dos padrões")]
        [MaxLength(50, ErrorMessage = "O nome deve conter menos de 50 caracteres")]
        [Display(Name = "Informe o NickName do usuario.")]
        public string NickName { get; set; }

        [Required]
        [Display(Name = "Informe a Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"^\w +[\w\.] *\@\w + ((-\w +)|(\w*))\.[a-z]{2,3}$", ErrorMessage = "O email está fora dos padrões")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]        
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^([a - zA - Z0 - 9@*#]{4,10})$", ErrorMessage = "A senha está fora dos padrões")]
        [StringLength(10, ErrorMessage = "A senha deve ter no minimo 4 e no máximo 10 caracteres", MinimumLength = 4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        
        [Display(Name = "digite seu endereço.")]
        [MinLength(5, ErrorMessage = "A descrição deve conter no min 5 caracteres.")]
        [MaxLength(30, ErrorMessage = "A descrição deve conter no máximo 30 caracteres.")]
        public string Endereco { get; set; }

        
        [Display(Name = "Caminho Imagem Usuario")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        public List<ViagemModel> Viagem { get; set; }

    }
}
