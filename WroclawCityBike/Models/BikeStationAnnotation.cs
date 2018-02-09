using CoreLocation;
using MapKit;

namespace WroclawCityBike.Models
{
    public class BikeStationAnnotation : MKAnnotation
    {
        private CLLocationCoordinate2D _coordinate;
        private readonly string _subtitle;
        private readonly string _title;

        public BikeStationAnnotation(CLLocationCoordinate2D coordinate, string title, string subtitle = "")
        {
            _coordinate = coordinate;
            _title = title;
            _subtitle = subtitle;
        }

        public override CLLocationCoordinate2D Coordinate { get { return _coordinate; } }
        public override string Title { get { return _title; } }
        public override string Subtitle { get { return _subtitle; } }

        public override void SetCoordinate(CLLocationCoordinate2D value)
        {
            _coordinate = value;
        }
    }
}
