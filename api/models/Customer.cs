namespace api.models
{
    public class Customer
    {
         public int customerID {get; set;}
        public string userName {get; set;}
        public string password {get; set;}
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string email {get; set;}
        public string phoneNumber {get; set;}
        public string customerAddress {get; set;}

        public override string ToString(){
            return customerID + " " + userName + " " + password + " " + firstName + " " + lastName + " " + email + " " + phoneNumber + " " + customerAddress + " ";
        }
    }
}