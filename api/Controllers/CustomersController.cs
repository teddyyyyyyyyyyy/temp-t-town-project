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
using api.interfaces.Customers;
using api.database.Customers;
using Microsoft.AspNetCore.Cors;
using Mysqlx.Crud;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET: api/Customers
        //[HttpGet]
        // public IEnumerable<Customers> Get()
        // {
        // List<Customers> customers = new List<Customers>();
        // ReadCustomers readin = new ReadCustomers();
        // customers = readin.GetCustomers();
        // return customers;
        // }

        // GET: api/Customers/5
        [HttpGet("{customerID}", Name = "Get")]
        public string Get(int customerID)
        {
            return "value";
        }

        // POST: api/Customers
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            try{
            ISaveCustomer save = new SaveCustomer();
            save.AddCustomer(customer);
        

       return Ok("Customer added successfully");
        }
        catch (Exception ex){
            return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding the customer");
        }
    }
// PUT: api/Customers/5
        [HttpPut("{customerID}")]
        [EnableCors("OpenPolicy")]
        public void Put(int customerID, Customer customer)
        {
            IEditCustomer edit = new EditCustomer();
            edit.EditACustomer(customerID, customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{customerID}")]
        [EnableCors("OpenPolicy")]
        public void DeleteCustomer(int customerID)
        {
            System.Console.WriteLine("Cannot delete customer");
        }
    }
}