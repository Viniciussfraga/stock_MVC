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
        [StringLength(50,ErrorMessage = "O tamanho máximo é 50 caracteres")]
        public string DepartamentoNome { get; set; }

        [Display(Name = "Descrição do departamento")]
        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }

    }
}
