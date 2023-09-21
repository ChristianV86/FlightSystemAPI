using FlightSystem.BLL.Models.Dto;

namespace FlightSystem.WebAPI.DataStore
{
    public static class FlightStore
    {
        public static List<FlightDto> flightList = new List<FlightDto>
        {
            new FlightDto {Id = 1, DepartureStation = "MZL", ArrivalStation = "MDE", Price = 200, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 8001 } }},
            new FlightDto {Id = 2, DepartureStation = "MZL", ArrivalStation = "CTG", Price = 200, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 8002 } }},
            new FlightDto {Id = 3, DepartureStation = "PEI", ArrivalStation = "BOG", Price = 200, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 8003 } }},
            new FlightDto {Id = 4, DepartureStation = "MDE", ArrivalStation = "BCN", Price = 500, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 8004 } }},
            new FlightDto {Id = 5, DepartureStation = "CTG", ArrivalStation = "CAN", Price = 300, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 8005 } }},
            new FlightDto {Id = 6, DepartureStation = "BOG", ArrivalStation = "MDA", Price = 500, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 8006 } }},
            new FlightDto {Id = 7, DepartureStation = "BOG", ArrivalStation = "MEX", Price = 300, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 8007 } }},
            new FlightDto {Id = 8, DepartureStation = "MZL", ArrivalStation = "PEI", Price = 200, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 8008 } }},
            new FlightDto {Id = 9, DepartureStation = "MDE", ArrivalStation = "CTG", Price = 200, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 8009 } }},
            new FlightDto {Id = 10, DepartureStation = "BOG", ArrivalStation = "CTG", Price =200, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 8010 } }},
            new FlightDto {Id = 11, DepartureStation = "MZL", ArrivalStation = "JFK", Price = 1000, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "AV", FlightNumber = 8020 } }},
            new FlightDto {Id = 12, DepartureStation = "JFK", ArrivalStation = "BCN", Price = 1000, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "AV", FlightNumber = 8040 } }},
            new FlightDto {Id = 13, DepartureStation = "MDE", ArrivalStation = "MZL", Price = 200, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 9001 } }},
            new FlightDto {Id = 14, DepartureStation = "CTG", ArrivalStation = "MZL", Price = 200, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 9002 } }},
            new FlightDto {Id = 15, DepartureStation = "BOG", ArrivalStation = "PEI", Price = 200, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 9003 } }},
            new FlightDto {Id = 16, DepartureStation = "BCN", ArrivalStation = "MDE", Price = 500, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "ES", FlightNumber = 9004 } }},
            new FlightDto {Id = 17, DepartureStation = "CAN", ArrivalStation = "CTG", Price = 300, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "MX", FlightNumber = 9005 } }},
            new FlightDto {Id = 18, DepartureStation = "MAD", ArrivalStation = "BOG", Price = 500, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "ES", FlightNumber = 9006 } }},
            new FlightDto {Id = 19, DepartureStation = "MEX", ArrivalStation = "BOG", Price = 500, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "MX", FlightNumber = 9007 } }},
            new FlightDto {Id = 20, DepartureStation = "PEI", ArrivalStation = "MZL", Price = 200, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 9008 } }},
            new FlightDto {Id = 21, DepartureStation = "CTG", ArrivalStation = "MDE", Price = 200, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 9009 } }},
            new FlightDto {Id = 22, DepartureStation = "CTG", ArrivalStation = "BOG", Price = 500, Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "CO", FlightNumber = 9010 } }},
        };
    }
}
