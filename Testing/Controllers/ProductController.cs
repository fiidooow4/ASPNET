using Microsoft.AspNetCore.Mvc;
using Testing.Models;
using Dapper;

namespace Testing.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }




        public IActionResult Index()
        {
            var products = repo.GetAllProducts();

            return View(products);
        }


    }

}

    

