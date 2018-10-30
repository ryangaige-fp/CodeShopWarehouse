using System;
using System.Collections.Generic;
using OrderSystems.Entities;
using OrderSystems.Data;

namespace OrderSystems.Business
{
    public class OrderService
    {

        private readonly IOrderRepo _orderRepo;

        public OrderService(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;

        }

        public List<Order> GetOrders()
        {
            return _orderRepo.GetOrders();

        }

        public Order GetOrderById(int id)
        {
            return _orderRepo.GetOrderById(id);

        }

        public Order UpdateOrder(Order o)
        {
            return _orderRepo.UpdateOrder(o);

        }


        public Order Create (Order order)
        {
            return _orderRepo.Create(order);
        }


        public Order ProcessOrder(Order order)
        {

            var currentOrder = GetOrderById(order.Id);

            if (currentOrder == null)
            {
                throw new Exception("Order Not Found");
            }
            if (currentOrder.Processed != false)
            {
                throw new Exception(" Order Already Processed Cannot Modify");
            }

            currentOrder.Processed = true;
            
            return currentOrder;

        }


    }
}
