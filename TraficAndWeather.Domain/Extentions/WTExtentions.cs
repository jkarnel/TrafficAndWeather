using Microsoft.Extensions.DependencyInjection;
using TraficAndWeather.Domain.Providers.Abstract;
using TraficAndWeather.Domain.Providers.Concrete;
using TraficAndWeather.Domain.Services.Abstract;
using TraficAndWeather.Domain.Services.Concrete;

namespace TraficAndWeather.Domain.Extentions
{
    public static class WTExtentions
    {
        public static void AddWT(this IServiceCollection services)
        {
            services.AddSingleton<IWTDataProvider, WTDataProvider>();
            services.AddSingleton<IWTService, WTService>();
        }
    }
}
