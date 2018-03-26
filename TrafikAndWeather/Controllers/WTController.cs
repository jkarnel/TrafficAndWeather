using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrafficAndWeather.Domain.Services.Abstract;
using TrafficAndWeather.Models;

namespace TrafficAndWeather.Controllers
{
    public class WTController : Controller
    {
        private readonly IWTService _service;
        private readonly IMapper _mapper;

        public WTController(IWTService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                Countries = GetCountries(),
                Towns = GetTowns()
            };
            return View(model);
        }

        [HttpGet]
        public PartialViewResult GetWeatherViewPartial(int? regionCode)
        {
            var weatherData = regionCode.HasValue ? _service.GetWeatherData(regionCode.Value) : null;
            WeatherViewModel viewData = null;
            if (weatherData != null)
            {
                viewData = _mapper.Map<WeatherViewModel>(weatherData);
            }
            return PartialView("_Weather", viewData);
        }

        [HttpGet]
        public PartialViewResult GetTrafficViewPartial(int? regionCode)
        {
            var trafficData = regionCode.HasValue ? _service.GetTrafficData(regionCode.Value) : null;
            TrafficViewModel viewData = null;
            if (trafficData != null)
            {
                viewData = _mapper.Map<TrafficViewModel>(trafficData);
            }
            return PartialView("_Traffic", viewData);
        }

        [HttpGet]
        public JsonResult GetWeatherData(int? regionCode)
        {
            var weatherData = regionCode.HasValue ? _service.GetWeatherData(regionCode.Value) : null;
            var viewData = _mapper.Map<WeatherViewModel>(weatherData);
            return Json(viewData);
        }

        [HttpGet]
        public JsonResult GetTrafficData(int? regionCode)
        {
            var trafficData = regionCode.HasValue ? _service.GetTrafficData(regionCode.Value) : null;
            var viewData = _mapper.Map<TrafficViewModel>(trafficData);
            return Json(viewData);
        }

        [HttpGet]
        public JsonResult GetTowns(int? countryId)
        {
            var townsData = countryId.HasValue ? GetTowns(countryId.Value) : null;
            return Json(townsData);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private IEnumerable<SelectListItem> GetCountries()
        {
            var countries = _mapper.Map<List<SelectListItem>>(_service.GetCountries());
            if (countries == null)
            {
                countries = new List<SelectListItem>();
            }
            countries.Insert(0, new SelectListItem { Value = "0", Selected = true, Text = "Страна не выбрана" });
            return countries;
        }

        private IEnumerable<SelectListItem> GetTowns(int countryId = 0)
        {
            var towns = new List<SelectListItem>();
            if (countryId != 0)
            {
                towns = _mapper.Map<List<SelectListItem>>(_service.GetTowns(countryId)) ?? new List<SelectListItem>();
            }
            towns.Insert(0, new SelectListItem { Value = "0", Selected = true, Text = "Город не выбран" });
            return towns;
        }
    }
}
