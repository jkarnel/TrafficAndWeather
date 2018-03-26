using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrafficAndWeather.Models
{
    public class TrafficViewModel
    {
        public int Stage { get; set; }
        public string RegionName { get; set; }
        public string DateTime { get; set; }
        public string Description { get; set; }
        public string Colour { get; set; }
    }
}
