using CoreBuisness;
using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    public class AddProductsUseCase : IAddProductsUseCase
    {
        private readonly IProductRepository productRepository;

        public AddProductsUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Execute(Product product)
        {
            productRepository.AddProduct(product);
        }

    }
}
