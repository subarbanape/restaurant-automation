namespace RestaurantAutomation.Beverages.Condiment
{
    public class Caramel : Condiment
    {
        public Caramel(int id, string name, float cost) : base(id, name, cost) { }

        public static Caramel Add() 
        { 
            return new Caramel()
        }
    }
}
