using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraficAndWeather.Domain.Entities.Abstract;
using TraficAndWeather.Models;

namespace TraficAndWeather.AutoMapperProfiles
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            ConfigureProfile();
        }

        private void ConfigureProfile()
        {
            CreateMap<IWeatherData, WeatherViewModel>();
            CreateMap<ITraficData, TrafiсViewModel>();
            CreateMap<IWTData, IndexViewModel>()
                .ForMember(x => x.TraficDetails, x => x.MapFrom(m => m.TraficData))
                .ForMember(x => x.WeatherDetails, x => x.MapFrom(m => m.WeatherData));
        }
    }
}
