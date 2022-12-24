using System.ComponentModel.DataAnnotations;

namespace ProjetoSite1.Models
{
    public class CategoriaModel
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Informe o nome da categoria.")]
        [MaxLength(50, ErrorMessage = "O nome deve conter menos de 50 caracteres")]
        [Display(Name = "Informe o nome da categoria")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres")]
        [MinLength(10, ErrorMessage = "A descrição deve ter no minimo 10 caracteres")]
        [Display(Name = "Informe a descricao")]
        public string Descricao { get; set; }

        public List<ViagemModel> Viagem { get; set; }

    }
}
