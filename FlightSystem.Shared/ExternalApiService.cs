using FlightSystem.DAL.Data;
using FlightSystem.DAL.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace FlightSystem.DAL
{
    public class ExternalApiService
    {
        private readonly HttpClient _httpClient;

        public ExternalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetExternalDataAsync()
        {
            try
            {
                // Realizar una solicitud GET a la API externa
                var response = await _httpClient.GetAsync("https://recruiting-api.newshore.es/api/flights/0");

                if (response.IsSuccessStatusCode)
                {
                    // Leer y retornar los datos
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    // Manejar el error si la solicitud no es exitosa
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                return null;
            }
        }
    }




    //public class ExternalApiService
    //{
    //private readonly HttpClient _httpClient;
    //// We inject access service to the database
    //private readonly ApplicationDbContext _context;

    //public ExternalApiService(HttpClient httpClient, ApplicationDbContext context)
    //{
    //    _httpClient = httpClient;
    //    _context = context;
    //}

    //public async Task<string> GetExternalDataAsync()
    //{
    //    try
    //    {
    //        // Realizar una solicitud GET a la API externa
    //        var response = await _httpClient.GetAsync("https://recruiting-api.newshore.es/api/flights/0");

    //        if (response.IsSuccessStatusCode)
    //        {
    //            // Leer y retornar los datos
    //            return await response.Content.ReadAsStringAsync();
    //        }
    //        else
    //        {
    //            // Manejar el error si la solicitud no es exitosa
    //            return null;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        // Manejar excepciones
    //        return null;
    //    }
    //}


    //public async Task<List<Flight>> GetExternalDataAsync()
    //{
    //    try
    //    {
    //        // Make a GET request to the external API
    //        var response = await _httpClient.GetAsync("https://recruiting-api.newshore.es/api/flights/0");
    //        //var response = await _httpClient.GetAsync("https://recruiting-api.newshore.es/api/flights/1");
    //        //var response = await _httpClient.GetAsync("https://recruiting-api.newshore.es/api/flights/2");

    //        if (response.IsSuccessStatusCode)
    //        {
    //            // Read and return data
    //            var json = await response.Content.ReadAsStringAsync();
    //            // We deserialize the data
    //            var result = JsonConvert.DeserializeObject<List<Flight>>(json);

    //            return result;

    //            //foreach (var flight in result)
    //            //{
    //            //    // We check if the data already exists to avoid duplicates
    //            //    var existFlight = _context.Fligths.Where(f =>
    //            //                                             f.Origin == flight.Origin &&
    //            //                                             f.Destination == flight.Destination &&                                                                 
    //            //                                             f.Transports == flight.Transports &&
    //            //                                             f.Price == flight.Price);

    //            //    if (existFlight != null)
    //            //    {
    //            //        // If the record does not exist
    //            //        //return ("A record with the same data already exists in the database.");
    //            //    }
    //            //    else
    //            //    {
    //            //        _context.Fligths.Add(flight);
    //            //    }
    //            //}

    //            // Guarda los datos en la base de datos.
    //            //var data = new Flight { };
    //            //_context.Fligths.Add(data);
    //            //await _context.SaveChangesAsync();
    //            //return result;
    //        }
    //        else
    //        {
    //            return null;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        return null;
    //    }
    //}
    //}
}