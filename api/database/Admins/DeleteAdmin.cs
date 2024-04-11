namespace api.database.Admins;
using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using api.models;
using api.interfaces.Admins;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

    public class DeleteAdmin : IDeleteAdmin
    {

        public void DeleteAnAdmin(int adminID)
        {
            ConnectionString connection = new ConnectionString();
            string cs = connection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            
            string stm = @"DELETE FROM AdminInformation WHERE adminID=@adminID";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@adminID", adminID);

            cmd.ExecuteNonQuery();
        }
    }

  