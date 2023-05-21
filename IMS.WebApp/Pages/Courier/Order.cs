namespace IMS.WebApp
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string OrderDetails { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        Shipped
    }
}