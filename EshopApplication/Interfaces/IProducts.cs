using Models;

namespace EshopApplication.Interfaces
{
    public interface IProducts
    {
        List<Products> GetProducts();

        Products AddProducts(Products products);
    }
}
