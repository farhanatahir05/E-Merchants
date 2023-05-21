using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IAddWishlistUseCase
    {
        Task ExecuteAsync(Product product, string userId);
    }
}