using System;
using System.Collections.Generic;
using System.Text;
using TrafficAndWeather.Domain.Entities.Abstract;

namespace TrafficAndWeather.Domain.Entities.Concrete
{
    internal sealed class TrafficData : ITrafficData
    {
        public int Stage { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public string RegionName { get; set; }
    }
}
