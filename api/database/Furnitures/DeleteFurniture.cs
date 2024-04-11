using api.interfaces.Furnitures;
namespace api.database.Furnitures;
using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using api.models;


    public class DeleteFurniture : IDeleteFurniture
    {
        public void DeleteAFurniture(int furnitureID)
        {
            ConnectionString connection = new ConnectionString();
            string cs = connection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            
            string stm = @"DELETE FROM FurnitureInformation WHERE furnitureID=@furnitureID";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@furnitureID", furnitureID);

            cmd.ExecuteNonQuery();
        }
    }
