using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorSPA.Models;
using BlazorSPA.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorSPA.Pages
{
    public class FetchDataBase : ComponentBase
    {
        [Inject] private IWeatherForecastService weatherForecastService { get; set; }

        protected WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await weatherForecastService.GetForecastAsync();
        }
    }
}
