using System.Security.AccessControl;
using api.interfaces.Customers;

namespace api.database.Customers
{
    public class DeleteCustomer : IDeleteCustomer
    {
        public static void DropCustomerInformationTable(){
            // ConnectionString myConnection = new ConnectionString();
            // string cs = myConnection.cs;

            // using var con = new MySqlConnection(cs);
            // con.Open();

            //drop part here
        }
        void IDeleteCustomer.DeleteCustomer(int customerID)
        {
            
        }
        
    }
}