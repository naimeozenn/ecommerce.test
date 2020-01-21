using ECommerce.Core.Domain;
using ECommerce.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            var result = _productService.Get(id);
           
            return View(result);
        }

        [HttpPost]
        public JsonResult Add(string name)
        {
            var result = _productService.Add(new Product
            {
                Name = name
            });

            return Json(result);
        }

        [HttpGet]
        public JsonResult GetByCategory(int categoryId)
        {
            var result = _productService.GetByCategory(categoryId);

            return Json(result);
        }
    }
}