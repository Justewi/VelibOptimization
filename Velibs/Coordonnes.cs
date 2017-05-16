using System;

namespace Velibs
{
    public class Coordonnes
    {
        public double Longitude;
        public double Latitude;

        public Coordonnes(double lat, double lon)
        {
            Longitude = lon;
            Latitude = lat;
        }

        public double Distance(Coordonnes coord)
        {
            return Math.Sqrt(Math.Pow(Latitude - coord.Latitude, 2) + Math.Pow(Longitude - coord.Longitude, 2));
        }
    }
}