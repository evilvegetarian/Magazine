using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    public class DeleteProductsUseCase : IDeleteProductsUseCase
    {
        private readonly IProductRepository productRepository;

        public DeleteProductsUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Execute(int productId)
        {
            productRepository.DeleteProduct(productId);
        }
    }
}
