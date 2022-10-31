using Stock_MVC.Models;

namespace Stock_MVC.ViewModels {
    public class ProdutoListViewModel {

        public IEnumerable<Produto> Produtos { get; set; }   
        public string CategoriaAtual { get; set; }
    }
}
