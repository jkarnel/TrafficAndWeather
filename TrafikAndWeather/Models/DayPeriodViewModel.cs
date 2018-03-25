using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraficAndWeather.Models
{
    public class DayPeriodViewModel
    {
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public int TemperatureFrom { get; set; }
        public int TemperatureTo { get; set; }
    }
}
