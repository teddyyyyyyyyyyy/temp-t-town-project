using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using api.models;
using api.interfaces.Admins;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
namespace api.database.Admins;


    public class SaveAdmin : ISaveAdmin
    {
        
        public void AddAdmin(Admin admin)
        {
            ConnectionString connection = new ConnectionString();
            string cs = connection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO AdminInformation(adminUsername, adminPassword, adminFirstName, adminLastName, adminEmail, adminPhoneNumber)
            VALUES(@adminUsername, @adminPassword, @adminFirstName, @adminLastName, @adminEmail, @adminPhoneNumber);";
            
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@adminUsername", admin.adminUsername);
            cmd.Parameters.AddWithValue("@adminPassword", admin.adminPassword);
            cmd.Parameters.AddWithValue("@adminFirstName", admin.adminFirstName);
            cmd.Parameters.AddWithValue("@adminLastName", admin.adminLastName);
            cmd.Parameters.AddWithValue("@adminEmail", admin.adminEmail);
            cmd.Parameters.AddWithValue("@adminPhoneNumber", admin.adminPhoneNumber);


            cmd.ExecuteNonQuery();

        }
    
        
    
}