using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class ViewUserDetailsByIdUseCase : IViewUserDetailsByIdUseCase
    {
        private readonly IWishlistRepository wishlistRepository;

        public ViewUserDetailsByIdUseCase(IWishlistRepository wishlistRepository)
        {
            this.wishlistRepository = wishlistRepository;
        }

        public async Task<UserDetails> ExecuteAsync(string userId)
        {
            return  await wishlistRepository.GetUserDetailsAsync(userId);
        }
    }
}
