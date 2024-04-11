using api.models;
namespace api.interfaces.Furnitures
{
    public interface IEditFurniture
    {
        public void EditAFurniture(int furnitureID, Furniture furniture);
    }
}