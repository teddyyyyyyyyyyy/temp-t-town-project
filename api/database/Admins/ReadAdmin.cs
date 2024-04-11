using api.interfaces.Admins;
using api.models;
using MySql.Data.MySqlClient;

namespace api.database.Admins
{
    public class ReadAdmins : IReadAdmins
    {
         public List<Admin> GetAdmins(){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
 
            string stm = @"SELECT * FROM AdminInformation"; 
            using var cmd = new MySqlCommand(stm, con);
 
            List<Admin> admins = new List<Admin>();
 
            MySqlDataReader read = cmd.ExecuteReader();
 
            while(read.Read()){
                Admin myAdmins = new Admin()
                {
                adminID = read.GetInt32(0),
                adminUsername = read.GetString(1),
                adminPassword = read.GetString(2),
                adminFirstName = read.GetString(3),
                adminLastName = read.GetString(4),
                adminEmail = read.GetString(5),
                adminPhoneNumber = read.GetString(6)
                };
                admins.Add(myAdmins);
            }
 
            return admins;
        
        }

        void IReadAdmins.GetAdmins(int adminID)
        {
            throw new NotImplementedException();
        }
    }
}