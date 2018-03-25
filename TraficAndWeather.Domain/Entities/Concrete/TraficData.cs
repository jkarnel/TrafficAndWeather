using System;
using System.Collections.Generic;
using System.Text;
using TraficAndWeather.Domain.Entities.Abstract;

namespace TraficAndWeather.Domain.Entities.Concrete
{
    internal sealed class TraficData : ITraficData
    {
        public int Stage { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public string RegionName { get; set; }
    }
}
