using api.models;
namespace api.interfaces.Admins
{
    public interface IEditAdmin
    {
         public void EditAnAdmin(int adminID, Admin admin);
    }
}