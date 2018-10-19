using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using OrderSystem.Entities;

namespace OrderSystem.Data
{

    public interface IOrderRepo
    {
        Order GetOrderByID(int id);
        List<Order> GetOrders();
        void UpdateOrder(Order order);
    }



    public class OrderRepo : IOrderRepo
    {

        private readonly IDbConnection _db;


        public OrderRepo (IDbConnection db)
        {
            _db = db;
        }

        public void UpdateOrder(Order order)

        {
            Console.WriteLine("Order Processed");

        }


        public Order GetOrderByID(int id)
        {
            var newOrder = new Order
            {
                Id = data.Id,
                Name = $"Order: {id}",
                Description = data.Description,
                ProcessedAt = DateTimeOffset.Now


            };

        }

        public List<Order> GetOrders()
        {

            return new List<Order>
            {
              
            };

        }


    }
}
