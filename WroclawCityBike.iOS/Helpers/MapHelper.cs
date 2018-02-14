using System;
using CoreLocation;
using MapKit;

namespace WroclawCityBike.iOS.Helpers
{
    public static class MapHelper
    {
        public static readonly CLLocationCoordinate2D WroclawCoordinates = new CLLocationCoordinate2D(51.107883, 17.038538);
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
            const double northLatitude = 51.211474;
            const double southLatitude = 51.042682;
            const double eastLongitude = 17.176348;
            const double westLongitude = 16.807380;

            if (userCoordinates.Latitude <= northLatitude &&
                userCoordinates.Latitude >= southLatitude &&
                userCoordinates.Longitude <= eastLongitude &&
                userCoordinates.Longitude >= westLongitude)
            {
                return true;
            }

            return false;
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
