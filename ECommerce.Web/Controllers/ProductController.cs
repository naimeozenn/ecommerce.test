using ECommerce.Core.Command.Products;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductCommand _getProductCommand;

        public ProductController(GetProductCommand getProductCommand)
        {
            _getProductCommand = getProductCommand;
        }

        public ActionResult Detail(int id)
        {
            _getProductCommand.ProductId = id;
            var result = _getProductCommand.Execute();
            return View(result);
        }
      
    }
}