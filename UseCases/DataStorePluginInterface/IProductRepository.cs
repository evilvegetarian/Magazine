using CoreBuisness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Product GetProductById(int productId);
        void DeleteProduct(int productId);
        IEnumerable<Product> GetProductByCategoryId(int categoryId);
    }
}