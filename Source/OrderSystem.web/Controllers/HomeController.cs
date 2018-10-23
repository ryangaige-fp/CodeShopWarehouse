using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using OrderSystem.Business;
using OrderSystem.Entities;



namespace OrderSystem.web.Controllers
{

    public class HomeController : Controller
    {
        private readonly OrderService _orderService;

        public HomeController(OrderService orderService)
        {

            _orderService = orderService;

        }

        [HttpGet]
        public IActionResult getOrders()
        {
            return ok(_orderService.GetOrders());

        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            return ok(_orderService.GetOrderById(id));

        }

        [HttpPost("close")]
        public IActionResult CloseTicket([FromBody]OrderSystem order) 
        {
            _orderService.CloseOrder(order);
            return ok();

        }

    }
}
