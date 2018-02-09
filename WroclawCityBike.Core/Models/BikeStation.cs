namespace WroclawCityBike.Core.Models
{
    public class BikeStation
    {
        public BikeStation(double latitude, double longitude, string location)
        {
            Latitude = latitude;
            Longitude = longitude;
            Location = location;
        }

        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public string Location { get; private set; }
    }
}
