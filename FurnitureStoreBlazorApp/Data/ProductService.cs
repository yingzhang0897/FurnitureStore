using FurnitureStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FurnitureStore.Data
{
    public class ProductService
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Modern Sofa", Description = "A comfortable modern sofa", Price = 499.99M, ImageUrl = "/images/sofa.jpg", Category = "Living Room" },
            new Product { Id = 2, Name = "Dining Table", Description = "Solid wood dining table", Price = 299.99M, ImageUrl = "/images/dining-table.jpg", Category = "Kitchen" },
            new Product { Id = 3, Name = "Office Chair", Description = "Ergonomic office chair", Price = 149.99M, ImageUrl = "/images/office-chair.jpg", Category = "Office" }
        };

        public Task<List<Product>> GetProductsAsync()
        {
            return Task.FromResult(_products);
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            var product = _products.Find(p => p.Id == id);
            return Task.FromResult(product);
        }
    }
}
