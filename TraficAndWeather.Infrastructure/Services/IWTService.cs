using System;
using System.Collections.Generic;
using System.Text;
using TraficAndWeather.Infrastructure.Entities;

namespace TraficAndWeather.Infrastructure.Services
{
    public interface IWTService
    {
        IWeatherData GetWeatherData(int regionCode);
        ITraficData GetTraficData(int regionCode);
        IWTData GetWTData(int regionCode);
        IEnumerable<ICountry> GetCountries();
        IEnumerable<ITown> GetTowns();
        ICountry GetCountry(int townId);
        IEnumerable<ITown> GetTowns(int coutryId);
    }
}
