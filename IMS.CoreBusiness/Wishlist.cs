namespace IMS.CoreBusiness
{
    public class Wishlist
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string UserId { get; set; }
        public bool IsCheckedOut { get; set; }
    }
}
