using BlazorSPA.Models;
using BlazorSPA.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorSPA.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private HttpClient client;

        public WeatherForecastService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            return await client.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}
