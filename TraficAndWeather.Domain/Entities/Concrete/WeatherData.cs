using System;
using System.Collections.Generic;
using System.Text;
using TraficAndWeather.Domain.Entities.Abstract;

namespace TraficAndWeather.Domain.Entities.Concrete
{
    internal sealed class WeatherData : IWeatherData
    {
        public int Temperature { get; set; }
        public byte[] Image { get; set; }
        public string Decsription { get; set; }
        public IEnumerable<IWeatherPeriodData> Periods { get; set; }
    }
}
