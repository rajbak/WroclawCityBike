using System.Collections.Generic;
using WroclawCityBike.Models;

namespace WroclawCityBike.Services
{
    public interface IDataService
    {
        IList<BikeStation> GetBikeStations();
    }
}
