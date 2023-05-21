using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class DeleteAllWishlistUseCase : IDeleteAllWishlistUseCase
    {
        private readonly IWishlistRepository wishlistRepository;

        public DeleteAllWishlistUseCase(IWishlistRepository wishlistRepository)
        {
            this.wishlistRepository = wishlistRepository;
        }

        public async Task ExecuteAsync(string userId)
        {
            await wishlistRepository.DeleteAllWishListAsync(userId);
        }
    }
}
