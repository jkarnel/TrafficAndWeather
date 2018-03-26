using System;
using System.Collections.Generic;
using System.Text;
using TrafficAndWeather.Domain.Entities.Abstract;

namespace TrafficAndWeather.Domain.Entities.Concrete
{
    internal sealed class WeatherData : IWeatherData
    {
        public string Temperature { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public IEnumerable<IWeatherPeriodData> Periods { get; set; }
    }
}
