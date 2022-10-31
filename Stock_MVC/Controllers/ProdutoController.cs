using Microsoft.AspNetCore.Mvc;
using Stock_MVC.Repositories.Interfaces;
using Stock_MVC.ViewModels;

namespace Stock_MVC.Controllers {
    public class ProdutoController : Controller {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository) {
            _produtoRepository = produtoRepository;
        }

        public IActionResult List() {

            //var produtos = _produtoRepository.Produtos;
            //return View(produtos);

            var produtoListViewModel = new ProdutoListViewModel();
            produtoListViewModel.Produtos = _produtoRepository.Produtos;
            produtoListViewModel.CategoriaAtual = "Categoria Atual";

            return View(produtoListViewModel);
        }
    }
}
