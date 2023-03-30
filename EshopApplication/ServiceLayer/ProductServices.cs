using EshopApplication.DBContextLayer;
using EshopApplication.Interfaces;
using Models;

namespace EshopApplication.ServiceLayer
{
    public class ProductServices:IProducts
    {
        private readonly EshopDB _Db;
        public ProductServices(EshopDB db)
        {
            _Db = db;
        }

        public Products AddProducts(Products products)
        {
            _Db.Products.Add(products);
            _Db.SaveChanges();
            return products;
        }

        public List<Products> GetProducts()
        {
            return _Db.Products.ToList();
        }
    }
}
