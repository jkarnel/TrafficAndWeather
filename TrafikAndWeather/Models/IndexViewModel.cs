using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraficAndWeather.Models;

namespace TraficAndWeather.Models
{
    public class IndexViewModel
    {
        public int Country { get; set; }
        public int Town { get; set; }
        public TrafiсViewModel TraficDetails { get; set; }
        public WeatherViewModel WeatherDetails { get; set; }
        public List<SelectListItem> Countries { get; set; }
        public List<SelectListItem> Towns { get; set; }
    }
}
