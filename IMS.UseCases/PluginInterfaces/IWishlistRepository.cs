using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IWishlistRepository
    {
        Task<List<Wishlist>> GetAllWishlistAsync(string userId);
        Task AddWishListAsync(Product product, string userId);
        Task DeleteWishListAsync(Wishlist wishList);
        Task DeleteAllWishListAsync(string userId);
        Task UpdateAllWishListAsync(string userId);
        Task AddUserDetailsAsync(UserDetails userDetails);
        Task<UserDetails> GetUserDetailsAsync(string userId);
    }
}
