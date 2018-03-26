using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficAndWeather.Domain.Entities.Abstract
{
    public interface IWeatherPeriodData
    {
        string PeriodName { get; set; }
        string ImageUrl { get; set; }
        string TemperatureFrom { get; set; }
        string TemperatureTo { get; set; }
    }
}
