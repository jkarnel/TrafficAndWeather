using System;
using System.Collections.Generic;
using System.Text;

namespace TraficAndWeather.Domain.Entities.Abstract
{
    public interface ITraficData
    {
        int Stage { get; set; }
        string Description { get; set; }
        DateTime DateTime { get; set; }
        string RegionName { get; set; }
    }
}
