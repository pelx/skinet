namespace Core.Entities.OrderAggregate
{
    public class OrderItem : BaseEntity
    {
        public OrderItem()
        {
        }

        public OrderItem(ProductItemOrdered itemOdered, decimal price, int quantity)
        {
            ItemOdered = itemOdered;
            Price = price;
            Quantity = quantity;
        }

        public ProductItemOrdered ItemOdered { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}