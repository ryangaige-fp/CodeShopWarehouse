using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using OrderSystems.Entities;

namespace OrderSystems.Data
{

    public interface IOrderRepo
    {
        Order GetOrderByID(int id);
        void UpdateOrder(Order order);
        Order CreateOrder(Order data);
        List<Order> GetOrders();
        IEnumerable<Order> GetUnProcessedOrders();
        IEnumerable<Order> GetOrdersByOrderId(int orderId);
        Order GetOrderById(int id);
    }



    public class OrderRepo : IOrderRepo
    {

        private readonly IDbConnection _db;


        public OrderRepo(IDbConnection db)
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
                Quantity = "blarg",
                ProcessedAt = DateTimeOffset.Now


            };

        }


        public List<Order> GetOrders()
        {
            return new List<Order>
            {
            GetOrderByID(1),
            GetOrderByID(2),
            GetOrderByID(3),
            GetOrderByID(4),
            GetOrderByID(5),
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
