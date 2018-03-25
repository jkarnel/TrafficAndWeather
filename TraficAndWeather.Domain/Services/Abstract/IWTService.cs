using System;
using System.Collections.Generic;
using System.Text;
using TraficAndWeather.Domain.Entities.Abstract;
using TraficAndWeather.Domain.Entities.Concrete;

namespace TraficAndWeather.Domain.Services.Abstract
{
    public interface IWTService
    {
        IWeatherData GetWeatherData(int regionCode);
        ITraficData GetTraficData(int regionCode);
        IWTData GetWTData(int regionCode);
        IEnumerable<Country> GetCountries();
        IEnumerable<Town> GetTowns();
        Country GetCountry(int townId);
        IEnumerable<Town> GetTowns(int coutryId);
    }
}
