using System;
using System.Threading.Tasks;
using OpenWeatherMap;
using LeadHornet.IPGeoCoding.Common.Models;
using System.Net;
using Newtonsoft.Json;

namespace LeadHornet.IPGeoCoding.Service
{
    public class NetworkUtilitiesService : Interface.INetworkServiceInterface
    {
        public const string _openWeatherApiKey = "2680ced11c7d03d841f7e8bfd6e706d0";

        public NetworkUtilitiesService()
        {

        }


        public async Task<CurrentWeatherResponse> GetWeatherByName(string locationName)
        {
            try
            {
                var client = new OpenWeatherMapClient(_openWeatherApiKey);
                CurrentWeatherResponse currentWeather = await client.CurrentWeather.GetByName(locationName);
                return currentWeather;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public async Task<CurrentWeatherResponse> GetByCoordinates(Coordinates coordinate)
        {
            try
            {
                var client = new OpenWeatherMapClient(_openWeatherApiKey);
                CurrentWeatherResponse currentWeather = await client.CurrentWeather.GetByCoordinates(coordinate);
                return currentWeather;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public async Task<Common.Models.IpInfo> GetWeatherByIp(string ipAddress)
        {

            try
            {
                var ipInfo = new Common.Models.IpInfo();
                try
                {
                    string info = new WebClient().DownloadString("http://ipinfo.io/" + ipAddress);
                    ipInfo = JsonConvert.DeserializeObject<Common.Models.IpInfo>(info);
                    return ipInfo;
                }
                catch (Exception)
                {
                    ipInfo.Country = null;
                }
                return ipInfo;

            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}