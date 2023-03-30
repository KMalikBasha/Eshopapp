using EshopApplication.DBContextLayer;
using EshopApplication.Interfaces;
using Models;

namespace EshopApplication.ServiceLayer
{
    public class CategoriesServices : ICategories
    {
        private readonly EshopDB _db;
     
        public CategoriesServices(EshopDB db)
        {
            _db = db;
        }
        public List<Categories> GetCategoriesList()
        {
            return _db.Categories.ToList();
        }
    }
}
