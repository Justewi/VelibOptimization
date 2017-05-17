using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Velibs.Properties;
using VelibsClient;

namespace Velibs
{
    public class VelibsOptimisation : IVelibsOptimisation
    {
        public string GetDirections(string origin, string destination)
        {
            MapsClient maps = new MapsClient(Settings.Default.GoogleMapsAPIKey);

            Coordonnes org = maps.GetCoordinates(origin);
            Coordonnes dest = maps.GetCoordinates(destination);

            VelibsStationsClient velibs = new VelibsStationsClient();

            Station station_org = velibs.GetClosestStation(org);
            Station station_dest = velibs.GetClosestStation(dest);

            return string.Format(station_org.Address + " -> " + station_dest.Address);
        }
    }
}
