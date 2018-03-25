using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraficAndWeather.Models
{
    public class TrafiсViewModel
    {
        public int Stage { get; set; }
        public string RegionName { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
    }
}
