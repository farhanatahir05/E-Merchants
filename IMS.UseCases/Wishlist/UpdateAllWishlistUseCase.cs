using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class UpdateAllWishlistUseCase : IUpdateAllWishlistUseCase
    {
        private readonly IWishlistRepository wishlistRepository;

        public UpdateAllWishlistUseCase(IWishlistRepository wishlistRepository)
        {
            this.wishlistRepository = wishlistRepository;
        }

        public async Task ExecuteAsync(string userId)
        {
            await wishlistRepository.UpdateAllWishListAsync(userId);
        }
    }
}
