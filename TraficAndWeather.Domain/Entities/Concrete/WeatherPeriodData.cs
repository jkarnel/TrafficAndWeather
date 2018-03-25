using System;
using System.Collections.Generic;
using System.Text;
using TraficAndWeather.Domain.Entities.Abstract;

namespace TraficAndWeather.Domain.Entities.Concrete
{
    internal sealed class WeatherPeriodData : IWeatherPeriodData
    {
        public string PeriodName { get; set; }
        public byte[] Image { get; set; }
        public int TemperatureFrom { get; set; }
        public int TemperatureTo { get; set; }
    }
}
