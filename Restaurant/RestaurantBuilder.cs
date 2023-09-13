using RestaurantAutomation.Common;
using RestaurantAutomation.Crew;
using System.Runtime.CompilerServices;

namespace RestaurantAutomation.Restaurant
{
    public class RestaurantBuilder
    {
        Restaurant restaurant;
        RestaurantDataManager restaurantDataManager = new RestaurantDataManager();
        string name;
        int id;
        CrewRequirements crewRequirements;

        public RestaurantBuilder Create(string name)
        {
            this.name = name;
            id = restaurantDataManager.Set(name);
            return this;
        }

        public RestaurantBuilder SetCrewRequirements(CrewRequirements requirements)
        {
            this.crewRequirements = requirements;
            return this;
        }

        public Restaurant Build()
        {
            var setupInfo = new SetupInfo(crewRequirements, null, null, null, null);
            return new Restaurant(name, id, setupInfo, null, RestaurantStatus.Ready);
        }
    }
}
