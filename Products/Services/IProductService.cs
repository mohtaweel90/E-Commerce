using System;
using Products.Models;

namespace Products.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        Product AddProduct(Product product);
        Product UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}

