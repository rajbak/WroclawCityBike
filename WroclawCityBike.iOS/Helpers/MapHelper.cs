using System;
using CoreLocation;
using MapKit;
using WroclawCityBike.Core;

namespace WroclawCityBike.iOS.Helpers
{
    public static class MapHelper
    {
        public static readonly CLLocationCoordinate2D WroclawCoordinates = new CLLocationCoordinate2D(Constants.Wroclaw.Latitiude, Constants.Wroclaw.Longitude);
        private const double DefaultAreaToDisplayInKm = 2;
        private const double EarthRadiusInKm = 6371.0;
        private const double RadiansToDegrees = 180.0;

        public static MKCoordinateRegion CreateRegion(CLLocationCoordinate2D coords, double areaToDisplayInKm = DefaultAreaToDisplayInKm)
        {
            MKCoordinateSpan span = new MKCoordinateSpan(KilometresToLatitudeDegrees(areaToDisplayInKm), KilometresToLongitudeDegrees(areaToDisplayInKm, coords.Latitude));

            return new MKCoordinateRegion(coords, span);
        }

        public static bool IsInWroclaw(CLLocationCoordinate2D userCoordinates)
        {
            var isInWroclaw = userCoordinates.Latitude <= Constants.Wroclaw.NorthLatitude &&
                              userCoordinates.Latitude >= Constants.Wroclaw.SouthLatitude &&
                              userCoordinates.Longitude <= Constants.Wroclaw.EastLongitude &&
                              userCoordinates.Longitude >= Constants.Wroclaw.WestLongitude;


            return isInWroclaw;
        }

        private static double KilometresToLatitudeDegrees(double kms)
        {
            double radiansToDegrees = RadiansToDegrees / Math.PI;

            return (kms / EarthRadiusInKm) * radiansToDegrees;
        }

        private static double KilometresToLongitudeDegrees(double kms, double atLatitude)
        {
            double degreesToRadians = Math.PI / RadiansToDegrees;
            double radiansToDegrees = RadiansToDegrees / Math.PI;
            double radiusAtLatitude = EarthRadiusInKm * Math.Cos(atLatitude * degreesToRadians);

            return (kms / radiusAtLatitude) * radiansToDegrees;
        }
    }
}
