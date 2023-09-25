using FlightSystem.BLL.Models;
using FlightSystem.BLL.Models.Dto;
using FlightSystem.DAL.Data;
using FlightSystem.DAL.Models;
using FlightSystem.DAL.Repository.IRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;

namespace FlightSystem.DAL
{
    public class ExternalApiService
    {
        private readonly HttpClient _httpClient;
        // We inject access service to the database
        private readonly ApplicationDbContext _context; 
       

        public ExternalApiService(HttpClient httpClient, 
                                   ApplicationDbContext context)
        {
            _httpClient = httpClient;
            _context = context;
            
        }

        public async Task<List<FlightDto>> GetExternalDataAsync()
        {
            // We create a database transaction using Entity Framework Core.
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                // Make a GET request to the external API
                var response = await _httpClient.GetAsync("https://recruiting-api.newshore.es/api/flights/2");

                if (response.IsSuccessStatusCode)
                {
                    // Read and return data                    
                    var json = await response.Content.ReadAsStringAsync();
                    // We deserialize the data
                    var result = JsonConvert.DeserializeObject<List<FlightDto>>(json);

                    foreach (var flightDto in result)
                    {
                        // Map FlightDto to a Transport entity (foreign key).
                        var transport = new Transport
                        {
                            FlightCarrier = flightDto.FlightCarrier,
                            FlightNumber = flightDto.FlightNumber
                        };                        

                        // Map FlightDto to a Flight entity.
                        var flight = new Flight
                        {
                            Origin = flightDto.DepartureStation,
                            Destination = flightDto.ArrivalStation,
                            Price = flightDto.Price
                        };

                        _context.Transports.Add(transport);
                        _context.Flights.Add(flight);
                                             
                    }                  
                    try
                    {
                        await _context.SaveChangesAsync();
                        transaction.Commit(); // Confirm the transaction if everything is fine.                       
                        Console.WriteLine("Data stored in the DB.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Reverts the transaction in case of error.
                        Console.WriteLine("Error: " + ex.Message);
                    }                    
                    return (result);
                }
                else
                {
                    throw new HttpRequestException("The HTTP request was not successful.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                // Roll back the transaction if an error occurs
                transaction.Rollback();
                // We remove an empty list
                return new List<FlightDto>();
            }
        }
    }
}
