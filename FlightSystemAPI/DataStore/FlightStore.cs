using FlightSystem.BLL.Models.Dto;

namespace FlightSystem.WebAPI.DataStore
{
    public static class FlightStore
    {
        public static List<FlightDto> flightList = new List<FlightDto>
        {
            new FlightDto{Origin="MZL", Destination="BCN", Transport="CO", FlightNumber = 8001, Price=200},
            new FlightDto{Origin="MZL", Destination="CTG", Transport="CO", FlightNumber = 8002, Price=200},
            new FlightDto{Origin="PEI", Destination="BOG", Transport="CO", FlightNumber = 8003, Price=200},
            new FlightDto{Origin="MDE", Destination="BCN", Transport="CO", FlightNumber = 8004, Price=500},
            new FlightDto{Origin="CTG", Destination="CAN", Transport="CO", FlightNumber = 8005, Price=300},
            new FlightDto{Origin="BOG", Destination="MDA", Transport="CO", FlightNumber = 8006, Price=500},
            new FlightDto{Origin="BOG", Destination="MEX", Transport="CO", FlightNumber = 8007, Price=300}
        };
    }
}
