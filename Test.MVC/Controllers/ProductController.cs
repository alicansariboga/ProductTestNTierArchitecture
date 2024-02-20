using Microsoft.AspNetCore.Mvc;
using Test.Business.Abstract;
using Test.Entities.Concrete;

namespace Test.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var result = _productService.GetAll();
            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            _productService.Add(product);
            return RedirectToAction("Index");
        }
    }
}
