using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficAndWeather.Domain.Entities.Abstract
{
    public interface IWeatherData
    {
        string Temperature { get; set; }
        string ImageUrl { get; set; }
        string Description { get; set; }
        IEnumerable<IWeatherPeriodData> Periods { get; set; }
    }
}
