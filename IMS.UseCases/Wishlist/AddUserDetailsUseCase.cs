using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class AddUserDetailsUseCase : IAddUserDetailsUseCase
    {
        private readonly IWishlistRepository wishlistRepository;

        public AddUserDetailsUseCase(IWishlistRepository wishlistRepository)
        {
            this.wishlistRepository = wishlistRepository;
        }

        public async Task ExecuteAsync(string name, string address, string contact, string userId)
        {
            var userDetails = new UserDetails
            {
                Name = name,
                Address = address,
                Contact = contact,
                UserId = userId
            };
            await wishlistRepository.AddUserDetailsAsync(userDetails);
        }
    }
}
