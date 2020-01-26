using OpenWeatherMap;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeadHornet.IPGeoCoding.Service.Interface
{
    public interface INetworkServiceInterface
    {
        Task<CurrentWeatherResponse> GetWeatherByName(string locationName);
        Task<Common.Models.IpInfo> GetWeatherByIp(string ipAddress);
        Task<CurrentWeatherResponse> GetByCoordinates(Coordinates coordinate);

    }
}
