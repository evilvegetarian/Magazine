using CoreBuisness;

namespace UseCases
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}