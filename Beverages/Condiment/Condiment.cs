using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Beverages.Condiment
{
    public class Condiment : Ingredient.Ingredient
    {
        public Condiment(int id, string name, float cost) : base(id, name, cost) { }

    }
}
