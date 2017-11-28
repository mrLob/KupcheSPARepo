using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KupcheAspNetCore.Models;

namespace  KupcheAspNetCore.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        [HttpGet]
        public IEnumerable<Orders> GetOrders()
        {
            using(servicedbContext db = new servicedbContext())
            {
                IEnumerable<Orders> tender =  db.Orders.ToList();
                Console.WriteLine("Get response orders!");
                return tender;
            }
        }

        [HttpPost]
        public IActionResult PostOrders([FromBody]Orders neworder)
        {
            if(ModelState.IsValid)
            {
                using(servicedbContext db = new servicedbContext()){
                    db.AddAsync(neworder);
                    db.SaveChangesAsync();
                    Console.WriteLine("Post response orders");
                    return Ok(neworder);
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        
    }
    
}