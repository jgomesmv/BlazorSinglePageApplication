using BlazorSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSPA.Services.Interfaces
{
    interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync();
    }
}
