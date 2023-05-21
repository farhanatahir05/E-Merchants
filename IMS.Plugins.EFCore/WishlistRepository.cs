using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore
{
    public class WishlistRepository : IWishlistRepository
    {
        private readonly IMSContext db;

        public WishlistRepository(IMSContext db)
        {
            this.db = db;
        }

        public async Task AddWishListAsync(Product product, string userId)
        {
            var wishlist = new Wishlist
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Price = product.Price,
                Quantity = product.Quantity,
                UserId = userId,
                IsCheckedOut = false
            };


            db.Wishlists.Add(wishlist);
            await db.SaveChangesAsync();
        }

        public async Task DeleteWishListAsync(Wishlist wishList)
        {
            if (wishList != null)
            {
                db.Wishlists.Remove(wishList);
                await db.SaveChangesAsync();
            }
        }

        public async Task<List<Wishlist>> GetAllWishlistAsync(string userId)
        {
            //var wishlists = await db.Wishlists.Where(x => x.UserId == userId).ToListAsync();
            var wishlists = await db.Wishlists.ToListAsync();
            return wishlists;
        }

        public async Task DeleteAllWishListAsync(string userId)
        {
            var wishlists = db.Wishlists.Where(x => x.UserId == userId);
            db.Wishlists.RemoveRange(wishlists);
            await db.SaveChangesAsync();
        }


        public async Task UpdateAllWishListAsync(string userId)
        {
            var wishlists = db.Wishlists.Where(x => x.UserId == userId).ToList();
            if (wishlists.Any())
            {
                foreach (var wishlist in wishlists)
                {
                    wishlist.IsCheckedOut = true;
                }
                db.Wishlists.UpdateRange(wishlists);
                await db.SaveChangesAsync();
            }
        }

        public async Task AddUserDetailsAsync(UserDetails userDetails)
        {
            db.UserDetails.Remove(userDetails);
            await db.SaveChangesAsync();
            db.UserDetails.Add(userDetails);
            await db.SaveChangesAsync();
        }

        public async Task<UserDetails> GetUserDetailsAsync(string userId)
        {
            //var userDetails = await db.UserDetails.Where(x => x.UserId == userId).FirstOrDefaultAsync();
            var userDetails = await db.UserDetails.FirstOrDefaultAsync();
            return userDetails;
        }

    }
}