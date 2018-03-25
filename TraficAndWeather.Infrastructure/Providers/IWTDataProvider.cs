using System;
using System.Collections.Generic;
using System.Text;
using TraficAndWeather.Infrastructure.Entities;

namespace TraficAndWeather.Infrastructure.Providers
{
    public interface IWTDataProvider
    {
        IWTData GetData(int regionCode, int cacheTime);
    }
}
