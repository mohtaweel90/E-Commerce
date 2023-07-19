using System;
using Products.Models;

namespace Products.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        Product AddProduct(Product product);
        Product UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}

