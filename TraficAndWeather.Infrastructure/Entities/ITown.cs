using System;
using System.Collections.Generic;
using System.Text;

namespace TraficAndWeather.Infrastructure.Entities
{
    public class ITown
    {
        public ICountry Country { get; private set; }
        public int RegionCode { get; set; }
        public string Name { get; set; }
    }
}
