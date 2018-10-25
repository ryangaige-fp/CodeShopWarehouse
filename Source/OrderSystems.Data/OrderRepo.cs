using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using OrderSystems.Entities;

namespace OrderSystems.Data
{

    public interface IOrderRepo
    {
        Order UpdateOrder(Order order);
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

        public Order CreateOrder(Order order)
        {
            order.Id = FakeDb.NextId;
            FakeDb.NextId += 1;
            FakeDb.Orders.Add(order);
            return order;
        }

        public Order UpdateOrder(Order order)

        {
            var o = GetOrderById(order.Id);
            if (o == null) { throw new Exception("Order not found!"); }
            o.Name = order.Name;
            o.Description = order.Description;
            o.Quantity = order.Quantity;
            o.CreatedAt = order.CreatedAt;
            return o;

        }


        public Order GetOrderById(int id)
        {

            return FakeDb.Orders.Find(o => o.Id == id);
        }


        public List<Order> GetOrders()
        {
            return FakeDb.Orders;
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
