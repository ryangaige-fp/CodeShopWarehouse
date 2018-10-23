using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderSystems.Business;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderSystem.webb.Controllers


{

    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {

        private readonly OrderService _orderService;
        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }


        // GET: api/values
        [HttpGet]
        public IActionResult getOrders()
        {
            return Ok(_orderService.GetOrders());

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            return Ok(_orderService.GetOrderById(id));

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
