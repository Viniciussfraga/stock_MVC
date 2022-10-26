using Stock_MVC.Models;

namespace Stock_MVC.Repositories.Interfaces {

    public interface IProdutoRepository {

        IEnumerable<Produto> Produtos { get; }
        IEnumerable<Produto> ProdutosPreferidos { get; }
        Produto GetProdutoId ( int lancheid );

    }
}
