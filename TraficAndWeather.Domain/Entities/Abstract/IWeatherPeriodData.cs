using System;
using System.Collections.Generic;
using System.Text;

namespace TraficAndWeather.Domain.Entities.Abstract
{
    public interface IWeatherPeriodData
    {
        string PeriodName { get; set; }
        byte[] Image { get; set; }
        int TemperatureFrom { get; set; }
        int TemperatureTo { get; set; }
    }
}
