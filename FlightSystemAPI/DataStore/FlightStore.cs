using FlightSystem.BLL.Models.Dto;

namespace FlightSystem.WebAPI.DataStore
{
    public static class FlightStore
    {
        public static List<FlightDto> flightList = new List<FlightDto>
        {
            new FlightDto{DepartureStation="MZL", ArrivalStation="MDE", FlightCarrier="CO", FlightNumber = 8001, Price=200},
            new FlightDto{DepartureStation="MZL", ArrivalStation="CTG", FlightCarrier="CO", FlightNumber = 8002, Price=200},
            new FlightDto{DepartureStation="PEI", ArrivalStation="BOG", FlightCarrier="CO", FlightNumber = 8003, Price=200},
            new FlightDto{DepartureStation="MDE", ArrivalStation="BCN", FlightCarrier="CO", FlightNumber = 8004, Price=500},
            new FlightDto{DepartureStation="CTG", ArrivalStation="CAN", FlightCarrier="CO", FlightNumber = 8005, Price=300},
            new FlightDto{DepartureStation="BOG", ArrivalStation="MDA", FlightCarrier="CO", FlightNumber = 8006, Price=500},
            new FlightDto{DepartureStation="BOG", ArrivalStation="MEX", FlightCarrier="CO", FlightNumber = 8007, Price=300}
        };
    }
}
