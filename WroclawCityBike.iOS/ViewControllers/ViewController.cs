using System;
using CoreLocation;
using UIKit;
using WroclawCityBike.iOS.Helpers;
using WroclawCityBike.Core.Services;
using WroclawCityBike.iOS.Models;

namespace WroclawCityBike.iOS.ViewControllers
{
    public partial class ViewController : UIViewController
    {
        private readonly IDataService _dataService = new MockDataService();
        private readonly CLLocationManager _locationManager = new CLLocationManager();

        protected ViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            RequestUserLocation();
            PrepareMap();
            AddAnnotations();
        }

        private void PrepareMap()
        {
            map.Region = MapHelper.CreateRegion(MapHelper.WroclawCoordinates);

            map.DidUpdateUserLocation += (sender, e) =>
            {
                var showUserLocation = map.UserLocation != null && MapHelper.IsInWroclaw(map.UserLocation.Coordinate);
                var coordinatesToDisplay = showUserLocation ? map.UserLocation.Coordinate : MapHelper.WroclawCoordinates;

                map.Region = MapHelper.CreateRegion(coordinatesToDisplay);
            };
        }

        private void RequestUserLocation()
        {
            _locationManager.RequestWhenInUseAuthorization();
            map.ShowsUserLocation = true;
        }

        private void AddAnnotations()
        {
            foreach (var station in _dataService.GetBikeStations())
            {
                var annotation = new BikeStationAnnotation(new CLLocationCoordinate2D(station.Latitude, station.Longitude), station.Location);
                map.AddAnnotation(annotation);
            }
        }
    }
}
