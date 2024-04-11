namespace api.database.Orders;
using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using api.models;
using api.interfaces.Orders;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

    public class DeleteOrder : IDeleteOrder
    {
        public void DeleteAnOrder(int orderID)
        {
            ConnectionString connection = new ConnectionString();
            string cs = connection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            
            string stm = @"DELETE FROM OrderInformation WHERE orderID=@orderID";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@orderID", orderID);

            cmd.ExecuteNonQuery();
        }
    }