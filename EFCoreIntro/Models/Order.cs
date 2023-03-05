namespace EFCoreIntro.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderPlaced { get; set; }

        public DateTime? OrderCompleted { get; set; }

        // foreign key relationship to the Customer table that will be generated
        // EFC would create it automatically (shadow property)
        public int CustomerId { get; set; }

        // navigation property
        public Customer Customer { get; set; } = null!;

        // another navigation property for viewing order details
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}