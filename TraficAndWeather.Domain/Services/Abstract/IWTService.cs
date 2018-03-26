using System;
using System.Collections.Generic;
using System.Text;
using TrafficAndWeather.Domain.Entities.Abstract;
using TrafficAndWeather.Domain.Entities.Concrete;

namespace TrafficAndWeather.Domain.Services.Abstract
{
    public interface IWTService
    {
        IWeatherData GetWeatherData(int regionCode);
        ITrafficData GetTrafficData(int regionCode);
        IWTData GetWTData(int regionCode);
        IEnumerable<Country> GetCountries();
        IEnumerable<Town> GetTowns();
        Country GetCountry(int townId);
        IEnumerable<Town> GetTowns(int coutryId);
    }
}
