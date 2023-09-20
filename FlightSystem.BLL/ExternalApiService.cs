﻿using FlightSystem.BLL.Models.Dto;
using FlightSystem.DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.BLL
{
    //We encapsulate Http requests in dedicated class of service
    public class ExternalApiService
    {
        private readonly HttpClient _httpClient;

        public ExternalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Flight>> GetExternalDataAsync()
        {
            try
            {
                // Realizar una solicitud GET a la API externa
                var response = await _httpClient.GetAsync("https://recruiting-api.newshore.es/api/flights/0");

                if (response.IsSuccessStatusCode)
                {
                    // Leer y retornar los datos
                    var json =  await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<Flight>>(json);
                    return result;
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
}
