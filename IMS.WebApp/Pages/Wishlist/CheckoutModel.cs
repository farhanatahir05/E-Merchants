using System.ComponentModel.DataAnnotations;

namespace IMS.WebApp.Pages.Wishlist
{
    public class CheckoutModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Contact is required.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        public string PaymentMethod { get; set; } = "cash";
    }
}
