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

        public double Latitude { get; }
        public double Longitude { get; }
        public string Location { get; }
    }
}
