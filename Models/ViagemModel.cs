using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSite1.Models
{
    public class ViagemModel
    {
        [Key]
        public int ViagemId { get; set; }

        [Required(ErrorMessage = "Informe o nome da viagem.")]
        [MaxLength(50, ErrorMessage = "O nome deve conter menos de 50 caracteres")]
        [Display(Name = "Informe o nome da viagem")]
        public string ViagemNome { get; set; }

        [Required(ErrorMessage = "Informe a descrição da viagem")]
        [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres")]
        [MinLength(10, ErrorMessage = "A descrição deve ter no minimo 10 caracteres")]
        [Display(Name = "Informe a descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A imagem é obrigatoria")]
        [Display(Name = "Caminho Imagem Usuario")]
        [StringLength(300, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImgUrl { get; set; }

        [Required]
        [Display(Name = "Informe a Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? DateTime { get; set; }


        [Required(ErrorMessage = "O valor precisa ser informado.")]
        [Display(Name = "Digite o valor do quadro")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999999.99, ErrorMessage = "O valor deve estar entre 1 e 999.999,99")]
        public decimal? Preco { get; set; }

        public int CategoriaId { get; set; }
        public CategoriaModel Categoria { get; set; }

        public int UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }
    }
}
