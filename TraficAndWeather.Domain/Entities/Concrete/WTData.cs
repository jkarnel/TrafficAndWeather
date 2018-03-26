using System;
using System.Collections.Generic;
using System.Text;
using TrafficAndWeather.Domain.Entities.Abstract;

namespace TrafficAndWeather.Domain.Entities.Concrete
{
    internal sealed class WTData : IWTData
    {
        public int RegionCode { get; set; }
        public string RegionName { get; set; }
        public DateTime DateTime { get; set; }
        public IWeatherData WeatherData { get; set; }
        public ITrafficData TrafficData { get; set; }
    }
}
