using System.Reflection.Emit;
using System.Data;
using System.Runtime.Serialization.Json;
using Internal;
using System.Security.Principal;
using System.Net;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.models;
using api.interfaces.Orders;
using api.database.Orders;
using Microsoft.AspNetCore.Cors;


//create new controller dotnet aspnet-codegenerator controller -name <name> -async -api --readWriteActions -outDir Controllers

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        // GET: api/Order/5
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public string GetOrders(int orderID)
        {
            return "value";
        }

        // POST: api/Order
        [HttpPost]
        public IActionResult PostOrder([FromBody] Order order)
        {
            try{
            ISaveOrder save = new SaveOrder();
            save.AddOrder(order);
        

       return Ok("Order added successfully");
        }
        catch (Exception ex){
            return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding the order");
        }
    }
        // PUT: api/Order/5
        [HttpPut("{orderID}")]
        [EnableCors("OpenPolicy")]
        public void Put(int orderID, Order order)
        {
            IEditOrder edit = new EditOrder();
            edit.EditAnOrder(orderID, order);
        }

        // DELETE: api/Order/5
        [HttpDelete("{orderID}")]
        [EnableCors("OpenPolicy")]
        public void DeleteOrder(int orderID)
        {
            IDeleteOrder delete = new DeleteOrder();
            delete.DeleteAnOrder(orderID);
        }
    }
}
