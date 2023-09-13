using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Common
{
    public class Criteria
    {
        public int MinQuantity { get; set; }
        public int MaxQuantity { get; set; }

        public static Criteria Create(int minQuantity, int maxQuantity) =>
                    new Criteria { MinQuantity = minQuantity, MaxQuantity = maxQuantity };
        public static Criteria Create(int minQuantity = 1) =>
                    new Criteria { MinQuantity = minQuantity };
    }
}
