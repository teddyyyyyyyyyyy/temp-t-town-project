using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using api.models;
using api.interfaces.Customers;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
namespace api.database.Customers;

    public class EditCustomer : IEditCustomer
    {
        public void EditACustomer(int customerID, Customer customer){
            ConnectionString connection = new ConnectionString();
            string cs = connection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE CustomerInformation SET userName=@userName, password=@password, 
                        firstName = @firstName, lastName = @lastName, email=@email, 
                        phoneNumber=@phoneNumber, customerAddress=@customerAddress WHERE customerID = @customerID;";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@userName", customer.userName);
            cmd.Parameters.AddWithValue("@password", customer.password);
            cmd.Parameters.AddWithValue("@firstName", customer.firstName);
            cmd.Parameters.AddWithValue("@lastName", customer.lastName);
            cmd.Parameters.AddWithValue("@email", customer.email);
            cmd.Parameters.AddWithValue("@phoneNumber", customer.phoneNumber);
            cmd.Parameters.AddWithValue("@customerAddress", customer.customerAddress);

            cmd.ExecuteNonQuery();
        }
    }
