namespace api.models
{
    public class Furniture
    {
        public int furnitureID {get; set;}
        public string furnitureName{get; set;}
        public double furnitureCost {get; set;}
        public string furnitureYear {get; set;}
        public string furnitureType {get; set;}
        public bool furnitureSold {get; set;}

        public override string ToString(){
            return furnitureID + " " + furnitureName + " " + furnitureCost + " " + furnitureYear + " " + furnitureType + " " + furnitureSold + " ";
        }
    }
}