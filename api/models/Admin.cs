namespace api.models
{
    public class Admin
    {
        public int adminID {get; set;}
        public string adminUsername {get; set;}
        public string adminPassword {get; set;}
        public string adminFirstName {get; set;}
        public string adminLastName {get; set;}
        public string adminEmail {get; set;}
        public string adminPhoneNumber {get; set;}
    
    public override string ToString(){
            return adminID + " " + adminUsername + " " + adminPassword + " " + adminFirstName + " " + adminLastName + " " + adminEmail + " " + adminPhoneNumber + " " ;
        }
    
    }
}