using System;
using System.Collections.Generic;
using System.Text;
using TrafficAndWeather.Domain.Entities.Abstract;

namespace TrafficAndWeather.Domain.Entities.Concrete
{
    public sealed class Town
    {
        public Country Country { get; set; }
        public int RegionCode { get; set; }
        public string Name { get; set; }
    }
}
