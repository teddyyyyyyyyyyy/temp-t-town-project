using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using api.models;
using api.interfaces.Furnitures;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
namespace api.database.Furnitures;

    public class SaveFurniture : ISaveFurniture
    {
        public void AddFurniture(Furniture furniture)
        {
            ConnectionString connection = new ConnectionString();
            string cs = connection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO FurnitureInformation(furnitureName, furnitureCost, furnitureYear, furnitureType, furnitureSold)
            VALUES(@furnitureName, @furnitureCost, @furnitureYear, @furnitureType, @furnitureSold)";
            
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@furnitureName", furniture.furnitureName);
            cmd.Parameters.AddWithValue("@furnitureCost", furniture.furnitureCost);
            cmd.Parameters.AddWithValue("@furnitureYear", furniture.furnitureYear);
            cmd.Parameters.AddWithValue("@furnitureType", furniture.furnitureType);
            cmd.Parameters.AddWithValue("@furnitureSold", furniture.furnitureSold);

            cmd.ExecuteNonQuery();

        }
    }
