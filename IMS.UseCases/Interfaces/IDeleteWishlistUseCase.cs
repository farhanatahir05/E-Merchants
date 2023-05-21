
using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IDeleteWishlistUseCase
    {
        Task ExecuteAsync(Wishlist wishlist);
    }
}