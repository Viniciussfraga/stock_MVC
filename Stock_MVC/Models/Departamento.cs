using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Stock_MVC.Models {
    [Table("Departamentos")]
    public class Departamento {
        [Key]
        public int DepartamentoId { get; set; }

        [Required(ErrorMessage = "O nome do departamento deve ser informado")]
        [Display(Name = "Nome do Departamento")]
        [MinLength(3, ErrorMessage = "O nome do departamento deve ter no mínimo {1} caracteres")]
        [MaxLength(50, ErrorMessage = "O nome do departamento deve ter no máximo {1} caracteres")]
        public string DepartamentoNome { get; set; }

        [Display(Name = "Descrição do departamento")]
        [MinLength(10, ErrorMessage = "Descrição do departamento deve ter no mínimo {1} caracteres")]
        [MaxLength(300, ErrorMessage = "Descrição do departamento deve ter no máximo {1} caracteres")]
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }

    }
}
