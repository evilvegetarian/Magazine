using CoreBuisness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;

        public ProductInMemoryRepository()
        {
            products = new List<Product>()
            {
                new Product{ProductId=1, CategoryId=1, Name="Bread", Quantity=100,Price=1.99},
                new Product{ProductId=2, CategoryId=2, Name="Cola 1l", Quantity=25,Price=0.99},
                new Product{ProductId=2, CategoryId=2, Name="Cola 0.5l", Quantity=25,Price=0.99},
                new Product{ProductId=3, CategoryId=3, Name="Knife", Quantity=2,Price=7.99},
                new Product{ProductId=4, CategoryId=3, Name="Axe", Quantity=2,Price=7.99}
            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase)))
                return;
            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
                product.ProductId= 1;
            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
            }
        }
        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(x=>x.ProductId== productId);
        }

        public void DeleteProduct(int productId)
        {
            products?.Remove(GetProductById(productId));
        }

        public IEnumerable<Product> GetProductByCategoryId(int categoryId)
        {
            return products.Where(x => x.CategoryId == categoryId);
        }
    }
}
