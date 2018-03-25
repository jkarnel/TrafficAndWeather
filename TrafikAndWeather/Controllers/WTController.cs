using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TraficAndWeather.Domain.Services.Abstract;
using TraficAndWeather.Models;

namespace TraficAndWeather.Controllers
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
            var regionCode = 143;
            var data = _service.GetWTData(regionCode);
            IndexViewModel model = _mapper.Map<IndexViewModel>(data);
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
