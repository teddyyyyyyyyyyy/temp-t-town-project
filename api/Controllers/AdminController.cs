using System.Collections;
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
using api.interfaces.Admins;
using api.database.Admins;
using Microsoft.AspNetCore.Cors;
using Mysqlx.Crud;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        // GET: api/Admin/5
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            List<Admin> admins = new List<Admin>();
            ReadAdmins readin = new ReadAdmins();
            admins = readin.GetAdmins();
            return admins;
        }

        // POST: api/Admin
        [HttpPost]
        public IActionResult PostAdmin([FromBody] Admin admin)
        {
            try{
            ISaveAdmin save = new SaveAdmin();
            save.AddAdmin(admin);
        

       return Ok("Admin added successfully");
        }
        catch (Exception ex){
            return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding the admin");
        }
    }
        // PUT: api/Admin/5
        [HttpPut("{adminID}")]
        [EnableCors("OpenPolicy")]
        public void PutAdmin(int adminID, Admin admin)
        {
            IEditAdmin edit = new EditAdmin();
            edit.EditAnAdmin(adminID, admin);
        }

        // DELETE: api/Admin/5
        [HttpDelete("{adminID}")]
        [EnableCors("OpenPolicy")]
        public void DeleteAdmin(int adminID)
        {
            IDeleteAdmin delete =  new DeleteAdmin();
            delete.DeleteAnAdmin(adminID);
        }
    }
}