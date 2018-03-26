using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficAndWeather.Domain.Entities.Abstract
{
    public interface ITrafficData
    {
        int Stage { get; set; }
        string Description { get; set; }
        string Colour { get; set; }
        DateTime DateTime { get; set; }
        string RegionName { get; set; }
    }
}
