using TrafficAndWeather.Domain.Data;
using TrafficAndWeather.Domain.Entities.Abstract;
using TrafficAndWeather.Domain.Providers.Abstract;
using TrafficAndWeather.Domain.Services.Abstract;
using System.IO;

namespace TrafficAndWeather.Domain.Providers.Concrete
{
    internal sealed class XMLWTDataProvider : IWTDataProvider
    {
        private readonly IWTDataReader _reader;

        public XMLWTDataProvider(IWTDataReader reader)
        {
            _reader = reader;
        }

        public IWTData GetData(int regionCode, int cacheTime = 0)
        {
            if (AppData.WTData.TryGetValue(regionCode, out string xmlPath))
            {
                var stream = File.Open(xmlPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                var result = _reader.ReadData(stream);
                return result;
            }
            return null;
        }
    }
}
