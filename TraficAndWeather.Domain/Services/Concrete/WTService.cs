using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TrafficAndWeather.Domain.Data;
using TrafficAndWeather.Domain.Entities.Abstract;
using TrafficAndWeather.Domain.Entities.Concrete;
using TrafficAndWeather.Domain.Services.Abstract;
using TrafficAndWeather.Domain.Providers.Abstract;

namespace TrafficAndWeather.Domain.Services.Concrete
{
    internal sealed class WTService : IWTService
    {
        private readonly IWTDataProvider _dataProvider;

        public WTService(IWTDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public IEnumerable<Country> GetCountries()
        {
            return AppData.CountriesData;
        }

        public Country GetCountry(int townId)
        {
            return AppData.CountriesData.Where(x => x.Towns.Select(y => y.RegionCode).Contains(townId)).FirstOrDefault();
        }

        public IEnumerable<Town> GetTowns()
        {
            return AppData.CountriesData.SelectMany(x => x.Towns);
        }

        public IEnumerable<Town> GetTowns(int coutryId)
        {
            return AppData.CountriesData.Where(x => x.RegionCode == coutryId).SelectMany(x => x.Towns);
        }

        public ITrafficData GetTrafficData(int regionCode)
        {
            var result = _dataProvider.GetData(regionCode);
            if(result != null)
            {
                return result.TrafficData;
            }
            return null;
        }

        public IWeatherData GetWeatherData(int regionCode)
        {
            var result = _dataProvider.GetData(regionCode);
            if (result != null)
            {
                return result.WeatherData;
            }
            return null;
        }

        public IWTData GetWTData(int regionCode)
        {
            return _dataProvider.GetData(regionCode);
        }
    }
}
