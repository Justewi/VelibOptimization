using System.Collections.Generic;
using Velibs.Properties;

namespace Velibs
{
    public class VelibsOptimisation : IVelibsOptimisation
    {
        public List<string> GetDirections(string origin, string destination)
        {
            MapsClient maps = new MapsClient(Settings.Default.GoogleMapsAPIKey);

            Coordonnes org = maps.GetCoordinates(origin);
            Coordonnes dest = maps.GetCoordinates(destination);

            VelibsStationsClient velibs = new VelibsStationsClient();

            Station stationOrg = velibs.GetClosestStation(org);
            Station stationDest = velibs.GetClosestStation(dest);

            List<string> directions = new List<string>();
            if (org.Distance(stationOrg.Coordonnes) + dest.Distance(stationDest.Coordonnes) < org.Distance(dest))
            {
                directions.AddRange(maps.GetDirections(org, stationOrg.Coordonnes, TravelMode.Walking));
                directions.Add("Get a velib from station " + stationOrg.Name);
                directions.AddRange(maps.GetDirections(stationOrg.Coordonnes, stationDest.Coordonnes,
                    TravelMode.Bicycling));
                directions.Add("Put back the velib at the station " + stationDest.Name);
                directions.AddRange(maps.GetDirections(stationDest.Coordonnes, dest, TravelMode.Walking));
            }
            else
            {
                directions.AddRange(maps.GetDirections(org,dest,TravelMode.Walking));
            }

            return directions;
        }
    }
}
