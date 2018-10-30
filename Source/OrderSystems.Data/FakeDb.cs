using System;
using System.Collections.Generic;
using OrderSystems.Entities;

namespace OrderSystems.Data
{
    public static class FakeDb
    {
        public static int NextId = 4;
        public static List<Order> Orders = new List<Order>() {
            new Order(){
                Id = 1,
                Name = "HydroFlasks",
                Quantity =  7,
                Description = "Double-Wall Insulated Water Bottles. Drinks Stay Icy Cold 24 Hrs",
                CreatedAt = DateTimeOffset.Now
            },
           new Order(){
                Id = 2,
                Name = "Dog Bones",
                Quantity =  16,
                Description = "Crunchy and delicious your dog will love them",
                CreatedAt = DateTimeOffset.Now
            },
            new Order(){
                Id = 3,
                Name = "Nintendo 64",
                Quantity =  10,
                Description = "64 bits of pure Nintendo power",
                CreatedAt = DateTimeOffset.Now
            },
        };
    }
}
