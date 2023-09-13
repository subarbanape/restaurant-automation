using RestaurantAutomation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.PriceBook
{
    public class Price
    {
        public UnitType UnitType { get; }
        public double Quantity { get; }
        public decimal Cost { get; }

        public Price(decimal cost)
        {
            UnitType = UnitType.Ounce;
            Cost = cost;
        }

        public Price(UnitType unitType, double quantity, decimal cost)
        {
            UnitType = unitType;
            Quantity = quantity;
            Cost = cost;
        }
    }
}
