using TraficAndWeather.Domain.Entities.Abstract;

namespace TraficAndWeather.Domain.Providers.Abstract
{
    public interface IWTDataProvider
    {
        IWTData GetData(int regionCode, int cacheTime = 0);
    }
}
