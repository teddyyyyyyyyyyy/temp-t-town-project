namespace api
{
    public class ConnectionString
    {
        public string cs {get; set;}

        public ConnectionString(){
            string server = "gk90usy5ik2otcvi.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "h3vfov5glbxyaiz0";
            string port = "3306";
            string userName = "vyz2fet963cbcxjc";
            string password = "ull5zjuyc2wj5ruj";

            cs = $@"server = {server}; user={userName}; database = {database}; port = {port}; password = {password};";
        }
    }
}