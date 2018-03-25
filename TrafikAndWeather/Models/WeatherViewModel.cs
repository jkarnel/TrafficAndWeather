using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraficAndWeather.Models;

namespace TraficAndWeather.Models
{
    public class WeatherViewModel
    {
        public int Temperature { get; set; }
        public string Description { get; set; }
        public List<DayPeriodViewModel> Periods { get; set; }
    }
}
