using EshopApplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EshopApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private ICategories _ICategories;
        public CategoriesController(ICategories categories) 
        {
            _ICategories = categories;
        }
        [HttpGet]
        [Route("GetCategories")]
        public IActionResult GetCategories()
        {
            var result = _ICategories.GetCategoriesList();
            return Ok(result);
        }
    }
}
