using Microsoft.Extensions.DependencyInjection;
using TrafficAndWeather.Domain.Providers.Abstract;
using TrafficAndWeather.Domain.Providers.Concrete;
using TrafficAndWeather.Domain.Services.Abstract;
using TrafficAndWeather.Domain.Services.Concrete;

namespace TrafficAndWeather.Domain.Extentions
{
    public static class WTExtentions
    {
        public static void AddWT(this IServiceCollection services)
        {
            services.AddSingleton<IWTDataProvider, XMLWTDataProvider>();
            services.AddSingleton<IWTService, WTService>();
        }
    }
}
