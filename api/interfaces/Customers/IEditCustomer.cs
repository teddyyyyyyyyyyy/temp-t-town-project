using api.models;
namespace api.interfaces.Customers
{
    public interface IEditCustomer
    {
        public void EditACustomer(int customerID, Customer costumer);
    }
}