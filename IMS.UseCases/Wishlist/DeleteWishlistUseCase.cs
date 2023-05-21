using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases
{
    public class DeleteWishlistUseCase : IDeleteWishlistUseCase
    {
        private readonly IWishlistRepository wishlistRepository;

        public DeleteWishlistUseCase(IWishlistRepository wishlistRepository)
        {
            this.wishlistRepository = wishlistRepository;
        }

        public async Task ExecuteAsync(Wishlist wishlist)
        {
            await this.wishlistRepository.DeleteWishListAsync(wishlist);
        }
    }
}
