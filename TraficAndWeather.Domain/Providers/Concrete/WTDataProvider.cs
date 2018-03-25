using System;
using System.Collections.Generic;
using System.Text;
using TraficAndWeather.Domain.Entities;
using TraficAndWeather.Domain.Entities.Abstract;
using TraficAndWeather.Domain.Providers.Abstract;

namespace TraficAndWeather.Domain.Providers.Concrete
{
    internal sealed class WTDataProvider : IWTDataProvider
    {
        public IWTData GetData(int regionCode, int cacheTime = 0)
        {
            throw new Exception();
        }
    }
}
