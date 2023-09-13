using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Crew
{
    public abstract class Crew
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CrewStatus Status { get; set; }
    }
}
