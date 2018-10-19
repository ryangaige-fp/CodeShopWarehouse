using System;


namespace OrderSystem.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string Descrition { get; set; }
        public DateTimeOffset ProcessedAt { get; set; }
        public DateTimeOffset ProcessedClosedAt { get; set; }
    }
}
