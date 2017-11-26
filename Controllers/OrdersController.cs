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
            using(servicedbContext db = new servicedbContext()){
                var tender =  db.Orders.ToList();
                
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