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
using api.interfaces.Furnitures;
using api.database.Furnitures;
using Microsoft.AspNetCore.Cors;
using Mysqlx.Crud;

namespace api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]

    public class FurnitureController : ControllerBase
    {

        //GET/api/Furniture/5
        [HttpGet("{furnitureID}", Name = "GetFurniture")]
        public string Get(int furnitureID){
            return "value";
        }

        //POST
        [HttpPost]
        public IActionResult PostFurniture([FromBody] Furniture furniture)
        {
            try{
            ISaveFurniture save = new SaveFurniture();
            save.AddFurniture(furniture);

            return Ok("Furniture added successfully");
            }
            catch (Exception ex){
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding the furniture");
            }
        }

        //PUT
        [HttpPut("{furnitureID}")]
        [EnableCors("OpenPolicy")]

        public void PutFurniture(int furnitureID, Furniture furniture)
        {
            IEditFurniture edit = new EditFurniture();
            edit.EditAFurniture(furnitureID, furniture);
        }

        //DELETE
        [HttpDelete("{furnitureID}")]
        [EnableCors("OpenPolicy")]

        public void DeleteFurniture(int furnitureID)
        {
            IDeleteFurniture delete = new DeleteFurniture();
            delete.DeleteAFurniture(furnitureID);
        }
    
    }
}