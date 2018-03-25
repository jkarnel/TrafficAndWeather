using System;
using System.Collections.Generic;
using System.Text;

namespace TraficAndWeather.Domain.Entities.Abstract
{
    public interface IWeatherData
    {
        int Temperature { get; set; }
        byte[] Image { get; set; }
        string Decsription { get; set; }
        IEnumerable<IWeatherPeriodData> Periods { get; set; }
    }
}
