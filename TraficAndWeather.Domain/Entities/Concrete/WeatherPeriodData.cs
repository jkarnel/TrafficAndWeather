using System;
using System.Collections.Generic;
using System.Text;
using TrafficAndWeather.Domain.Entities.Abstract;

namespace TrafficAndWeather.Domain.Entities.Concrete
{
    internal sealed class WeatherPeriodData : IWeatherPeriodData
    {
        public string PeriodName { get; set; }
        public string ImageUrl { get; set; }
        public string TemperatureFrom { get; set; }
        public string TemperatureTo { get; set; }
    }
}
