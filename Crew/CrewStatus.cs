using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Crew
{
    public enum CrewStatus
    {
        Unknown = 0,
        Available = 1,
        AvailableSoon = 2,
        TimeOff = 3,
        Sick = 4,
        Busy = 5,
        Offline = 6,
        Maintenance = 7,
        Down = 8,
    }
}
