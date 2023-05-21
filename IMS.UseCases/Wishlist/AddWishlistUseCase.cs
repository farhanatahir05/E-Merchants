using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases
{
    public class AddWishlistUseCase : IAddWishlistUseCase
    {
        private readonly IWishlistRepository wishlistRepository;

        public AddWishlistUseCase(IWishlistRepository wishlistRepository)
        {
            this.wishlistRepository = wishlistRepository;
        }

        public async Task ExecuteAsync(Product product, string userId)
        {
            if (product == null) return;

            await wishlistRepository.AddWishListAsync(product, userId);
        }
    }
}
