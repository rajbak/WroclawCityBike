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
        private const double AreaToDisplayInKm = 10;
        private static readonly CLLocationCoordinate2D WroclawCoords = new CLLocationCoordinate2D(51.107883, 17.038538);
        private readonly IDataService _dataService = new MockDataService();

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            map.Region = MapHelper.GetRegionToDisplay(AreaToDisplayInKm, WroclawCoords);
            AddAnnotations();

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
