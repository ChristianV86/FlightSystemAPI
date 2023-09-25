using FlightSystem.BLL.Models.Dto;

namespace FlightSystem.WebAPI.DataStore
{
    public static class FlightStore
    {
        public static List<FlightDto> flightList = new List<FlightDto>
        {
            new FlightDto {DepartureStation = "MZL", ArrivalStation = "MDE", Price = 200,  FlightCarrier = "CO", FlightNumber = "8001"},
            new FlightDto {DepartureStation = "MZL", ArrivalStation = "CTG", Price = 200, FlightCarrier = "CO", FlightNumber = "8002"},
            new FlightDto {DepartureStation = "PEI", ArrivalStation = "BOG", Price = 200, FlightCarrier = "CO", FlightNumber = "8003"},
            new FlightDto {DepartureStation = "MDE", ArrivalStation = "BCN", Price = 500, FlightCarrier = "CO", FlightNumber = "8004"},
            new FlightDto {DepartureStation = "CTG", ArrivalStation = "CAN", Price = 300, FlightCarrier = "CO", FlightNumber = "8005"},
            new FlightDto {DepartureStation = "BOG", ArrivalStation = "MDA", Price = 500, FlightCarrier = "CO", FlightNumber = "8006"},
            new FlightDto {DepartureStation = "BOG", ArrivalStation = "MEX", Price = 300, FlightCarrier = "CO", FlightNumber = "8007"},
            new FlightDto {DepartureStation = "MZL", ArrivalStation = "PEI", Price = 200, FlightCarrier = "CO", FlightNumber = "8008"},
            new FlightDto {DepartureStation = "MDE", ArrivalStation = "CTG", Price = 200, FlightCarrier = "CO", FlightNumber = "8009"},
            new FlightDto {DepartureStation = "BOG", ArrivalStation = "CTG", Price =200, FlightCarrier = "CO", FlightNumber = "8010"},
            new FlightDto {DepartureStation = "MZL", ArrivalStation = "JFK", Price = 1000, FlightCarrier = "AV", FlightNumber = "8020"},
            new FlightDto {DepartureStation = "JFK", ArrivalStation = "BCN", Price = 1000, FlightCarrier = "AV", FlightNumber = "8040"},
            new FlightDto {DepartureStation = "MDE", ArrivalStation = "MZL", Price = 200, FlightCarrier = "CO", FlightNumber = "9001"},
            new FlightDto {DepartureStation = "CTG", ArrivalStation = "MZL", Price = 200, FlightCarrier = "CO", FlightNumber = "9002"},
            new FlightDto {DepartureStation = "BOG", ArrivalStation = "PEI", Price = 200, FlightCarrier = "CO", FlightNumber = "9003"},
            new FlightDto {DepartureStation = "BCN", ArrivalStation = "MDE", Price = 500, FlightCarrier = "ES", FlightNumber = "9004"},
            new FlightDto {DepartureStation = "CAN", ArrivalStation = "CTG", Price = 300, FlightCarrier = "MX", FlightNumber = "9005"},
            new FlightDto {DepartureStation = "MAD", ArrivalStation = "BOG", Price = 500, FlightCarrier = "ES", FlightNumber = "9006"},
            new FlightDto {DepartureStation = "MEX", ArrivalStation = "BOG", Price = 500, FlightCarrier = "MX", FlightNumber = "9007"},
            new FlightDto {DepartureStation = "PEI", ArrivalStation = "MZL", Price = 200, FlightCarrier = "CO", FlightNumber = "9008"},
            new FlightDto {DepartureStation = "CTG", ArrivalStation = "MDE", Price = 200, FlightCarrier = "CO", FlightNumber = "9009"},
            new FlightDto {DepartureStation = "CTG", ArrivalStation = "BOG", Price = 500, FlightCarrier = "CO", FlightNumber = "9010"},
        };
    }
}
