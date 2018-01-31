using System;
using CoreLocation;
using UIKit;
using WroclawCityBike.Helpers;

namespace WroclawCityBike
{
    public partial class ViewController : UIViewController
    {
        const double AreaToDisplayInKm = 10;
        static readonly CLLocationCoordinate2D WroclawCoords = new CLLocationCoordinate2D(51.107883, 17.038538);

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            map.Region = MapHelper.GetRegionToDisplay(AreaToDisplayInKm, WroclawCoords);
        }
    }
}
