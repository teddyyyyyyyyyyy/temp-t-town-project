using api.models;
namespace api.interfaces.Orders
{
    public interface IDeleteOrder
    {
         public void DeleteAnOrder(int orderID);
    }
}