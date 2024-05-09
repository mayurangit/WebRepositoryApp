using Microsoft.AspNetCore.Mvc;
using WebRepositoryApp.Models;
using WebRepositoryApp.Repository.Interface;

namespace WebRepositoryApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductInterface _productInterface;
        public ProductController(IProductInterface productInterface)
        {
            _productInterface = productInterface;
            
        }
        public async Task<IActionResult> Index()
        {
            var x = await _productInterface.Get();
            return View(x);
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            if(ModelState.IsValid)
            {
                await _productInterface.Create(product);

                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
