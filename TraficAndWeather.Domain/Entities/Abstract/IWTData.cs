using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficAndWeather.Domain.Entities.Abstract
{
    public interface IWTData
    {
        int RegionCode { get; set; }
        string RegionName { get; set; }
        DateTime DateTime { get; set; }
        IWeatherData WeatherData { get; set; }
        ITrafficData TrafficData { get; set; }
    }
}
