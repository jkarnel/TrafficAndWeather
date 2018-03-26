using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrafficAndWeather.Domain.Entities.Abstract;
using TrafficAndWeather.Domain.Entities.Concrete;
using TrafficAndWeather.Models;

namespace TrafficAndWeather.AutoMapperProfiles
{
    public class WTProfile : Profile
    {
        public WTProfile()
        {
            ConfigureProfile();
        }

        private void ConfigureProfile()
        {
            CreateMap<IWeatherData, WeatherViewModel>();
            CreateMap<ITrafficData, TrafficViewModel>();
            CreateMap<IWeatherPeriodData, DayPeriodViewModel>();
            CreateMap<IWTData, IndexViewModel>()
                .ForMember(x => x.TrafficDetails, x => x.MapFrom(m => m.TrafficData))
                .ForMember(x => x.WeatherDetails, x => x.MapFrom(m => m.WeatherData));
            CreateMap<Country, SelectListItem>()
                .ForMember(x => x.Text, x => x.MapFrom(m => m.Name))
                .ForMember(x => x.Value, x => x.MapFrom(m => m.RegionCode));
            CreateMap<Town, SelectListItem>()
                .ForMember(x => x.Text, x => x.MapFrom(m => m.Name))
                .ForMember(x => x.Value, x => x.MapFrom(m => m.RegionCode));
        }
    }
}
