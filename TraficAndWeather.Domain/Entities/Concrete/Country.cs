using System;
using System.Collections.Generic;
using System.Text;
using TraficAndWeather.Domain.Entities.Abstract;

namespace TraficAndWeather.Domain.Entities.Concrete
{
    public sealed class Country
    {
        public int RegionCode { get; set; }
        public string Name { get; set; }
        public IEnumerable<Town> Towns { get; set; }
    }
}
