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
        void UpdateOrder(Order order);
        Order CreateOrder(Order data);
        IEnumerable<Order> GetUnProcessedOrders();
        IEnumerable<Order> GetOrdersByOrderId(int orderId);
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
            return new Order
            {
                Id = id,
                Name = $"Order: {id}",
                Description = "blarg",
                ProcessedAt = DateTimeOffset.Now


            };

        }

        internal IEnumerable<Order> GetUnProcessedOrders()
        {

            //return _db.Query<Order>("SELECT * FROM orders;");

        }

        internal IEnumerable<Order> GetOrdersByOrderId(int orderId)
        {

           

        }



    }
}
