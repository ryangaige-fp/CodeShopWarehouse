using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using OrderSystems.Entities;

namespace OrderSystems.Data
{

    public interface IOrderRepo
    {
        void UpdateOrder(Order order);
        Order CreateOrder(Order data);
        List<Order> GetOrders();
        IEnumerable<Order> GetUnProcessedOrders();
        IEnumerable<Order> GetOrdersByProductId(int orderId);
        Order GetOrderById(int id);
    }



    public class OrderRepo : IOrderRepo
    {

        private readonly IDbConnection _db;


        public OrderRepo(IDbConnection db)
        {
            _db = db;
        }

        public Order CreateOrder(Order data)
        {
            return null;
        }

        public void UpdateOrder(Order order)

        {
            Console.WriteLine("Order Processed");

        }


        public Order GetOrderById(int id)
        {
            return new Order
            {
                Id = id,
                Name = $"Order: {id}",
                Quantity = 7,
                ProcessedAt = DateTimeOffset.Now
            };

        }


        public List<Order> GetOrders()
        {
            return new List<Order>
            {
            GetOrderById(1),
            GetOrderById(2),
            GetOrderById(3),
            GetOrderById(4),
            GetOrderById(5),
            };
        }

        public IEnumerable<Order> GetUnProcessedOrders()
        {

            return null;
            //return _db.Query<Order>("SELECT * FROM orders;");

        }

        public IEnumerable<Order> GetOrdersByProductId(int orderId)
        {

            return null;

        }


    }
}
