using System;
using Products.Models;
using Products.Repositories;

namespace Products.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetProducts();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public Product AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        public Product UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }
    }
}

