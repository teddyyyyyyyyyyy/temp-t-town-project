using api.models;
namespace api.interfaces.Customers
{
    public interface ISaveCustomer
    {
       public void AddCustomer(Customer customer);
       public void CustomerSave(Customer customer);
    }
}