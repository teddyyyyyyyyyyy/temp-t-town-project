using api.models;
namespace api.interfaces.Orders
{
    public interface IEditOrder
    {
        public void EditAnOrder(int orderID, Order order);
    }
}