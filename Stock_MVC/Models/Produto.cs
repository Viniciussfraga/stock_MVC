using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_MVC.Models {
    [Table("Produtos")]
    public class Produto {

        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome do produto deve ser informado")]
        [Display(Name = "Nome do Produto")]
        [MinLength(3, ErrorMessage = "O nome do produto deve ter no mínimo {1} caracteres")]
        [MaxLength(50, ErrorMessage = "O nome do produto deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição do Produto")]
        [MinLength(10, ErrorMessage = "Descrição do produto deve ter no mínimo {1} caracteres")]
        [MaxLength(300, ErrorMessage = "Descrição do produto deve ter no máximo {1} caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O preço do produto deve ser informado")]
        [Display(Name = "Preço do Produto")]
        public decimal Preco { get; set; }

        [Display(Name = "Imagem do Produto")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Imagem Thumbnail do Produto")]
        public string ImagemThumbnailUrl { get; set; }
        [Required]
        [Display(Name = "Produto preferido")]
        public bool IsProdutoPreferido { get; set; }
        [Required]
        [Display(Name = "Stock do produto")]
        public bool EmEstoque { get; set; }

        public int DepartamentoId { get; set; }
    
        public virtual Departamento Departamento { get; set; }
    }
}
