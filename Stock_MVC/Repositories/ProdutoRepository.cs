using Microsoft.EntityFrameworkCore;
using Stock_MVC.Context;
using Stock_MVC.Models;
using Stock_MVC.Repositories.Interfaces;

namespace Stock_MVC.Repositories {
    public class ProdutoRepository : IProdutoRepository {

        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context) {
            _context = context;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos.Include(d => d.Departamento);

        public IEnumerable<Produto> ProdutosPreferidos => _context.Produtos.Where(p => p.IsProdutoPreferido).Include(d => d.Departamento);

        public Produto GetProdutoId(int produtoId) {
            return _context.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
        }
    }
}
