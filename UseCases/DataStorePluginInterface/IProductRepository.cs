using CoreBuisness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}