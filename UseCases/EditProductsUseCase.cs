using CoreBuisness;

namespace UseCases
{
    public class EditProductsUseCase : IEditProductsUseCase
    {
        private readonly IProductRepository productRepository;

        public EditProductsUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void Execute(Product product)
        {
            productRepository.UpdateProduct(product);
        }
    }
}
