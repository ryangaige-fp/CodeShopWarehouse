﻿using System;
using System.Collections.Generic;
using OrderSystem.Data;
using OrderSystem.Entities;

namespace OrderSystem.Business
{
    public class OrderService
    {

        private readonly IOrderRepo _orderRepo;

        public OrderService (IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;

        }

        public List<Order> GetOrders()
        {
            return _orderRepo.GetOrders();

        }

        public Order GetOrderById (int id)
        {
            return _orderRepo.GetOrderByID(id);

        }

        public Order ProcessOrder (Order order)
        {

            var currentOrder = GetOrderById(order.Id);

            if (currentOrder == null)
            {
                throw new Exception("Order Not Found");
            }
            if (currentOrder.ProcessedClosedAt != null)
            {
                throw new Exception(" Order Already Processed Cannot Modify");
            }

          


        }


    }
}
