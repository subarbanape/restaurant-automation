using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Common
{
    public abstract class SystemInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ConnectionInfo { get; set; }
    }
}
