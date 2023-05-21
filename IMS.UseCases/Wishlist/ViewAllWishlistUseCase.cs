using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class ViewAllWishlistUseCase : IViewAllWishlistUseCase
    {
        private readonly IWishlistRepository wishlistRepository;

        public ViewAllWishlistUseCase(IWishlistRepository wishlistRepository)
        {
            this.wishlistRepository = wishlistRepository;
        }

        public async Task<List<Wishlist>> ExecuteAsync(string userId)
        {
            return  await wishlistRepository.GetAllWishlistAsync(userId);
        }
    }
}
