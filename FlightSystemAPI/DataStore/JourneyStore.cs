using FlightSystem.BLL.Models.Dto;

namespace FlightSystem.WebAPI.DataStore
{
    public static class JourneyStore
    {
        public static List<JourneyDto> journeyList = new List<JourneyDto>
        {
            new JourneyDto
            {                            
                            Origin = "MZL", 
                            Destination = "BCN", 
                            Price= 1000 + 1000,
                            Flights = new List<FlightDto> { new FlightDto {DepartureStation = "MZL", 
                                                                           ArrivalStation = "JFK", 
                                                                           Price = 1000,
                                                                           Transports = new List<TransportDto> { new TransportDto { FlightCarrier = "AV", FlightNumber = 8020}}
                                                           },
                                                           new FlightDto {DepartureStation = "JFK",
                                                                          ArrivalStation = "BCN",
                                                                          Price = 1000,
                                                                          Transports = new List<TransportDto> {new TransportDto { FlightCarrier = "AV", FlightNumber = 8040}}
                                                           }
                            }                            
            }
        };
    }
}
