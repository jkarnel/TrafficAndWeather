using System;
using System.Collections.Generic;
using System.Text;

namespace TraficAndWeather.Domain.Entities.Abstract
{
    public interface IWTData
    {
        int RegionCode { get; set; }
        string RegionName { get; set; }
        DateTime DateTime { get; set; }
        IWeatherData WeatherData { get; set; }
        ITraficData TraficData { get; set; }
    }
}
