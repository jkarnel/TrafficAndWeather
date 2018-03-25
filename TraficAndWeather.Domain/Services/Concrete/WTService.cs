using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TraficAndWeather.Domain.Data;
using TraficAndWeather.Domain.Entities.Abstract;
using TraficAndWeather.Domain.Entities.Concrete;
using TraficAndWeather.Domain.Services.Abstract;
using TraficAndWeather.Domain.Providers.Abstract;

namespace TraficAndWeather.Domain.Services.Concrete
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
            return Countries.CountriesData;
        }

        public Country GetCountry(int townId)
        {
            return Countries.CountriesData.Where(x => x.Towns.Select(y => y.RegionCode).Contains(townId)).FirstOrDefault();
        }

        public IEnumerable<Town> GetTowns()
        {
            return Countries.CountriesData.SelectMany(x => x.Towns);
        }

        public IEnumerable<Town> GetTowns(int coutryId)
        {
            return Countries.CountriesData.Where(x => x.RegionCode == coutryId).SelectMany(x => x.Towns);
        }

        public ITraficData GetTraficData(int regionCode)
        {
            return _dataProvider.GetData(regionCode).TraficData;
        }

        public IWeatherData GetWeatherData(int regionCode)
        {
            return _dataProvider.GetData(regionCode).WeatherData;
        }

        public IWTData GetWTData(int regionCode)
        {
            return _dataProvider.GetData(regionCode);
        }
    }
}
