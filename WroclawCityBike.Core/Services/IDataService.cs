using System.Collections.Generic;
using WroclawCityBike.Core.Models;

namespace WroclawCityBike.Core.Services
{
    public interface IDataService
    {
        IList<BikeStation> GetBikeStations();
    }
}
