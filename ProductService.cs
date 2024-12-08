using HW_ASP_9._0.Models;
using System.Collections.Generic;
using System.Linq;

namespace HW_ASP_9._0
{
    public class ProductService
    {
        private readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Laptop", Price = 1500, Category = "Electronics", Description = "High-performance laptop" },
        new Product { Id = 2, Name = "Coffee Maker", Price = 80, Category = "Appliances", Description = "Automatic coffee maker" }
    };

        public IEnumerable<Product> GetAll() => _products;

        public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public void Update(Product updatedProduct)
        {
            var product = GetById(updatedProduct.Id);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Price = updatedProduct.Price;
                product.Category = updatedProduct.Category;
                product.Description = updatedProduct.Description;
            }
        }
    }
}
