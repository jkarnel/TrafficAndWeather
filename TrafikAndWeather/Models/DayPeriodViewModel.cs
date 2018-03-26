using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrafficAndWeather.Models
{
    public class DayPeriodViewModel
    {
        public string PeriodName { get; set; }
        public string ImageUrl { get; set; }
        public string TemperatureFrom { get; set; }
        public string TemperatureTo { get; set; }
    }
}
