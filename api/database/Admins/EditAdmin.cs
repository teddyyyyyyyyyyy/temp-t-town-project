using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using api.models;
using api.interfaces.Admins;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
namespace api.database.Admins;

    public class EditAdmin : IEditAdmin
    {
        public void EditAnAdmin(int adminID, Admin admin){
            ConnectionString connection = new ConnectionString();
            string cs = connection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE AdminInformation SET adminUsername=@adminUsername, adminPassword=@adminPassword, 
                        adminFirstName = @adminFirstname, adminLastName = @adminLastName, adminEmail=@adminEmail, 
                        adminPhoneNumber=@adminPhoneNumber, WHERE adminID = @adminID;";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@adminID", admin.adminID);
            cmd.Parameters.AddWithValue("@adminUsername", admin.adminUsername);
            cmd.Parameters.AddWithValue("@adminPassword", admin.adminPassword);
            cmd.Parameters.AddWithValue("@adminFirstName", admin.adminFirstName);
            cmd.Parameters.AddWithValue("@adminLastName", admin.adminLastName);
            cmd.Parameters.AddWithValue("@adminEmail", admin.adminEmail);
            cmd.Parameters.AddWithValue("@adminPhoneNumber", admin.adminPhoneNumber);

            cmd.ExecuteNonQuery();
        }
    }