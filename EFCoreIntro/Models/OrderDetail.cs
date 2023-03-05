namespace EFCoreIntro.Models
{
    // this will generate an intersection table to represent many → many relationship between
    // Order and Product
    public class OrderDetail
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        // represents foreign key relationship, isn't strictly required
        public int ProductId { get; set; }

        // represents foreign key relationship, isn't strictly required
        public int OrderId { get; set; }

        public Order Order { get; set; } = null!;

        public Product Product { get; set; } = null!;
    }
}