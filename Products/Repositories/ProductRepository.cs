using System;
using Products.Data;
using Products.Models;

namespace Products.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductsDbContext _context;

        public ProductRepository(ProductsDbContext context)
        {
            _context = context;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public Product AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public Product UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return product;
        }

        public bool DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return false;
            }

            _context.Products.Remove(product);
            _context.SaveChanges();
            return true;
        }
    }

}

