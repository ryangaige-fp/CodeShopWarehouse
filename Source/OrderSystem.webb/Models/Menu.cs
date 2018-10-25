using OrderSystems.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSystem.Webb.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public List<Order> Orders { get; set; }
    }
}