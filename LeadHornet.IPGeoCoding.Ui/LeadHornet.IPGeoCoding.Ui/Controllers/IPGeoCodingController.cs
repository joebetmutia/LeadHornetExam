using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Http;
using OpenWeatherMap;

namespace LeadHornet.IPGeoCoding.Ui.Controllers
{
    public class IPGeoCodingController : Controller
    {
        private IHttpContextAccessor _accessor;
        private Service.Interface.INetworkServiceInterface _networkService;

        public IPGeoCodingController(IHttpContextAccessor accessor, Service.Interface.INetworkServiceInterface networkService)
        {
            _accessor = accessor;
            _networkService = networkService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }


        public async Task<IActionResult> GetClientWeather(Models.ViewModel.IPGeoCodingViewModel param)
        {
            var dto = new Models.Dto.ClientWeatherDto();

            CurrentWeatherResponse currentWeatherCountryName = await _networkService.GetWeatherByName(param.CountryName);

            var tempWeatherIP = await _networkService.GetWeatherByIp(param.IPAddress);
            CurrentWeatherResponse currentWeatherIPAddress = await _networkService.GetByCoordinates(new Coordinates()
            {
                Latitude = Convert.ToDouble(tempWeatherIP.Loc.Split(",")[0]),
                Longitude = Convert.ToDouble(tempWeatherIP.Loc.Split(",")[1]),
            });

            dto.CurrentWeather_CountryName = currentWeatherCountryName;
            dto.CurrentWeather_IP = currentWeatherIPAddress;

            return Ok(dto);
        }

        public IActionResult Test()
        {

            return View();
        }
    }
}