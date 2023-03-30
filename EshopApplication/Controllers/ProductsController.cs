using EshopApplication.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EshopApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProducts _IProducts;
        public ProductsController(IProducts products)
        {
            _IProducts = products;
        }
        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            var result = _IProducts.GetProducts();
            return Ok(result);
        }

        [HttpPost]
        [Route("AddProducts")]
        public IActionResult AddProducts(Products products)
        {
            _IProducts.AddProducts(products);
            return Created("/" + products.Id, products);
        }
    }
}
