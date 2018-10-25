using System;


namespace OrderSystems.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset ProcessedAt { get; set; }
    }
}
