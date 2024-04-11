using api.models;
namespace api.interfaces.Orders
{
    public interface ISaveOrder
    {
         public void AddOrder(Order order);
    }
}