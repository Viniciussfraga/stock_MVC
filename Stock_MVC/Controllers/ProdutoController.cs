using Microsoft.AspNetCore.Mvc;

namespace Stock_MVC.Controllers {
    public class ProdutoController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
