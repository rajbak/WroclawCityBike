using System;
using CoreLocation;
using UIKit;
using WroclawCityBike.iOS.Helpers;
using WroclawCityBike.Core.Services;
using WroclawCityBike.iOS.Models;
using System.Linq;
using MapKit;
using Foundation;

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

            map.DidUpdateUserLocation += OnDidUpdateUserLocation;
            map.DidSelectAnnotationView += OnDidSelectAnnotationView;
            map.OverlayRenderer += OnOverlayRenderer;
        }

        private void RequestUserLocation()
        {
            if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
            {
                _locationManager.RequestWhenInUseAuthorization();
            }

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

        private void OnDidUpdateUserLocation(object sender, MKUserLocationEventArgs e)
        {
            var showUserLocation = map.UserLocation != null && MapHelper.IsInWroclaw(map.UserLocation.Coordinate);
            var coordinatesToDisplay = showUserLocation ? map.UserLocation.Coordinate : MapHelper.WroclawCoordinates;

            map.SetRegion(MapHelper.CreateRegion(coordinatesToDisplay), true);
        }

        private void OnDidSelectAnnotationView(object sender, MKAnnotationViewEventArgs e)
        {
            var annotation = map.SelectedAnnotations.First();

            if (annotation is BikeStationAnnotation bikeStationAnnotation)
            {
                var selectedBikeStation = new MKPlacemark(bikeStationAnnotation.Coordinate);

                var directionRequest = new MKDirectionsRequest
                {
                    Source = MKMapItem.MapItemForCurrentLocation(),
                    Destination = new MKMapItem(selectedBikeStation),
                    RequestsAlternateRoutes = false,
                    TransportType = MKDirectionsTransportType.Walking
                };

                var direction = new MKDirections(directionRequest);
                direction.CalculateDirections(OnDirectionsCalculated);
            }
        }

        private MKPolylineRenderer OnOverlayRenderer(MKMapView mapView, IMKOverlay overlay)
        {
            return MapHelper.GetPolylineRenderer(overlay);
        }

        private void OnDirectionsCalculated(MKDirectionsResponse response, NSError error)
        {
            if (error != null)
            {
                Console.WriteLine($"Error while calculating directions, error: {error}");
                return;
            }

            if (response == null || !response.Routes.Any())
            {
                Console.WriteLine($"Couldn't calculate directions.");
                return;
            }

            if (map.Overlays != null && map.Overlays.Any())
            {
                map.RemoveOverlays(map.Overlays);
            }

            var route = response.Routes.First();
            map.AddOverlay(route.Polyline, MKOverlayLevel.AboveRoads);

            var rect = route.Polyline.BoundingMapRect;
            map.SetRegion(MKCoordinateRegion.FromMapRect(rect), animated: true);
        }
    }
}
