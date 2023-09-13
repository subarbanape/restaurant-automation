using RestaurantAutomation.Ingredient;

namespace RestaurantAutomation.Beverages.Coffee
{
    public class CoffeeBase : Ingredient.Ingredient
    {
        public CoffeeBase(int id, float cost) : base(id, cost) { }
    }
}
