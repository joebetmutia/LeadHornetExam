using OpenWeatherMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeadHornet.IPGeoCoding.Ui.Models.Dto
{
    public class ClientWeatherDto
    {
        public string IPAddress { get; set; }
        public string CountryName { get; set; }
        public WeatherItem CurrentWeather_IP { get; set; }
        public WeatherItem CurrentWeather_CountryName { get; set; }
    }
}
