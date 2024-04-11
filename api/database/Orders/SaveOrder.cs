using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using api.models;
using api.interfaces.Orders;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
namespace api.database.Orders;

    public class SaveOrder : ISaveOrder
    {
         public void AddOrder(Order order)
        {
            ConnectionString connection = new ConnectionString();
            string cs = connection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO OrderInformation(productName, productNumber, payment, status)
            VALUES(@productName, @productNumber, @payment, @status)";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@productName", order.productName);
            cmd.Parameters.AddWithValue("@productNumber", order.productNumber);
            cmd.Parameters.AddWithValue("@payment", order.payment);
            cmd.Parameters.AddWithValue("@status", order.status);

            cmd.ExecuteNonQuery();

        }
    }
