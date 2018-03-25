using System;
using System.Collections.Generic;
using System.Text;
using TraficAndWeather.Domain.Entities.Concrete;

namespace TraficAndWeather.Domain.Data
{
    public static class Countries
    {
        static Countries()
        {
            var countries = new List<Country>();
            var ukr = new Country { Name = "Украина", RegionCode = 187 };
            var usa = new Country { Name = "США", RegionCode = 84 };
            var rus = new Country { Name = "Россия", RegionCode = 225 };

            var kiev = new Town { Name = "Киев", RegionCode = 143, Country = ukr };
            var kharkiv = new Town { Name = "Харьков", RegionCode = 147, Country = ukr };
            var lviv = new Town { Name = "Львов", RegionCode = 144, Country = ukr };

            var ny = new Town { Name = "Нью-Йорк", RegionCode = 202, Country = usa };
            var la = new Town { Name = "Лос-Анджелес", RegionCode = 200, Country = usa };
            var detr = new Town { Name = "Детройт", RegionCode = 89, Country = usa };

            var mosc = new Town { Name = "Москва", RegionCode = 213, Country = rus };
            var sa = new Town { Name = "Санкт-Петербург", RegionCode = 2, Country = rus };

            countries.Add(ukr);
            countries.Add(usa);
            countries.Add(rus);
            CountriesData = countries;
        }

        public static IEnumerable<Country> CountriesData { get; private set; }
    }
}
