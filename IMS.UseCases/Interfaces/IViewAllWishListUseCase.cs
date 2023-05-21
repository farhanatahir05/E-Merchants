using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IViewAllWishlistUseCase
    {
        Task<List<Wishlist>> ExecuteAsync(string userId);
    }
}