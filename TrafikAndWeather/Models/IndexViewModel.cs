using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrafficAndWeather.Models;

namespace TrafficAndWeather.Models
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            TrafficDetails = new TrafficViewModel();
            WeatherDetails = new WeatherViewModel();
            Countries = new List<SelectListItem>();
            Towns = new List<SelectListItem>();
        }
        public TrafficViewModel TrafficDetails { get; set; }
        public WeatherViewModel WeatherDetails { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }
        public IEnumerable<SelectListItem> Towns { get; set; }
    }
}
