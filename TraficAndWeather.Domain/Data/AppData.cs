using System;
using System.Collections.Generic;
using System.Text;
using TrafficAndWeather.Domain.Entities.Concrete;
using System.IO;
using System.Reflection;

namespace TrafficAndWeather.Domain.Data
{
    public static class AppData
    {
        public static IEnumerable<Country> CountriesData { get; private set; }
        public static Dictionary<int, string> WTData { get; private set; }

        static AppData()
        {
            InitializeCounties();
            InitializeWTData();
        }

        private static void InitializeCounties()
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

            ukr.Towns = new List<Town> { kiev, kharkiv, lviv };
            usa.Towns = new List<Town> { ny, la, detr };
            rus.Towns = new List<Town> { mosc, sa };

            countries.Add(ukr);
            countries.Add(usa);
            countries.Add(rus);
            CountriesData = countries;
        }

        private static void InitializeWTData()
        {
            string basePath = "wwwroot/xml";

            var dictionary = new Dictionary<int, string>
            {
                [143] = basePath + "/KyivData.xml",
                [147] = basePath + "/KharkivData.xml",
                [144] = basePath + "/LvivData.xml",
                [202] = basePath + "/NYData.xml",
                [200] = basePath + "/LosAngData.xml",
                [89] = basePath + "/DetroitData.xml",
                [213] = basePath + "/MoscowData.xml",
                [2] = basePath + "/SPBData.xml"
            };
            WTData = dictionary;
        }
    }
}
