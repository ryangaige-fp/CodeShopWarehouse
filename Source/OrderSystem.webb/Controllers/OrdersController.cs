using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrderSystems.Business;
using OrderSystems.Entities;
using OrderSystem.webb.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderSystem.webb.Controllers


{

    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {

        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }


        // GET: api/values
        [HttpGet]
        public List<Order> GetAll()
        {
            return _orderService.GetOrders();

        }

        [HttpGet("{id}")]
        public Order GetById(int id)
        {
            return _orderService.GetOrderById(id);

        }

        [HttpPut("{id}")]
        public Order ProcessOrder(int id)
        {
            var o = _orderService.GetOrderById(id);
            return _orderService.ProcessOrder(o);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            //this would need to go and delete one
            return "deleted";
        }

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View(_orderService.GetOrders());

        //}

        // GET api/values/5
        //[HttpGet("{id}")]
        //public IActionResult Details(int id)
        //{
        //    var order = _orderService.GetOrderById(id);
        //    if (order == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(order);

        //}

        //public IActionResult Create()
        //{
        //    return View("Create");

        //}



        // POST api/values
        //[HttpPost]
        //public IActionResult Create(Order order)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Order o = _orderService.Create(order);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(order);
        //}

        //[HttpPut("{id}")]
        //public IActionResult ProcessOrder ( int id)
        //{
        //    var o = _orderService.GetOrderById(id);
        //    _orderService.ProcessOrder(o);
        //    return View("Index");
        //}



    }
}
