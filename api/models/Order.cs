namespace api.models
{
    public class Order
    {
        public int orderID {get; set;}
        public string productName {get; set;}
        public string productNumber {get; set;}
        public bool payment {get; set;}
        public bool status {get; set;}
    }
}