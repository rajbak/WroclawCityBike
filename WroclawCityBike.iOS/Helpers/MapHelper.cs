using System;
using CoreLocation;
using MapKit;

namespace WroclawCityBike.iOS.Helpers
{
    public static class MapHelper
    {
        const double EarthRadiusInKm = 6371.0;
        const double RadiansToDegrees = 180.0;

        public static MKCoordinateRegion GetRegionToDisplay(double areaToDisplayInKm, CLLocationCoordinate2D coords)
        {
            MKCoordinateSpan span = new MKCoordinateSpan(KilometresToLatitudeDegrees(areaToDisplayInKm), KilometresToLongitudeDegrees(areaToDisplayInKm, coords.Latitude));

            return new MKCoordinateRegion(coords, span);
        }

        static double KilometresToLatitudeDegrees(double kms)
        {
            double radiansToDegrees = RadiansToDegrees / Math.PI;

            return (kms / EarthRadiusInKm) * radiansToDegrees;
        }

        static double KilometresToLongitudeDegrees(double kms, double atLatitude)
        {
            double degreesToRadians = Math.PI / RadiansToDegrees;
            double radiansToDegrees = RadiansToDegrees / Math.PI;
            double radiusAtLatitude = EarthRadiusInKm * Math.Cos(atLatitude * degreesToRadians);

            return (kms / radiusAtLatitude) * radiansToDegrees;
        }
    }
}
