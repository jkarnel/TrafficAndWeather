using TrafficAndWeather.Domain.Entities.Abstract;

namespace TrafficAndWeather.Domain.Providers.Abstract
{
    public interface IWTDataProvider
    {
        IWTData GetData(int regionCode, int cacheTime = 0);
    }
}
