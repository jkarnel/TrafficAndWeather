using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrafficAndWeather.Models;

namespace TrafficAndWeather.Models
{
    public class WeatherViewModel
    {
        public WeatherViewModel()
        {
            Periods = new List<DayPeriodViewModel>();
        }

        public string Temperature { get; set; }
        public string Description  { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<DayPeriodViewModel> Periods { get; set; }
    }
}
