using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Velibs
{
    public class MapsClient
    {
        private string APIKey;

        public MapsClient(string APIKey)
        {
            this.APIKey = APIKey;
        }

        public List<string> GetDirections(string origin, string destination,TravelMode mode)
        {
            string response = Requester.SendRequest(
                "https://maps.googleapis.com/maps/api/directions/json?" +
                "origin=" + origin +
                "&destination=" + destination +
                "&mode=" + mode.Mode +
                "&key=" + APIKey
            );
            JObject json = JObject.Parse(response);
            List<JToken> steps = json["routes"].First["legs"].First["steps"].Children().ToList();
            List<string> route = new List<string>();
            foreach (JToken step in steps)
            {
                route.Add(step["html_instructions"].ToString());
            }

            return route;
        }

        public List<string> GetDirections(Coordonnes origin, Coordonnes destination, TravelMode mode)
        {
            return GetDirections(
                origin.Latitude + "," + origin.Longitude,
                destination.Latitude + "," + destination.Longitude,
                mode
            );
        }

        public Coordonnes GetCoordinates(string address)
        {
            string response = Requester.SendRequest("https://maps.googleapis.com/maps/api/geocode/json?address="+address+"&key="+APIKey);
            JObject json = JObject.Parse(response);
            double lat = (double) json["results"].First["geometry"]["location"]["lat"];
            double lng = (double) json["results"].First["geometry"]["location"]["lng"];
            return new Coordonnes(lat,lng);

        }
    }

    public class TravelMode
    {
        public string Mode { get; }
        private TravelMode(string mode)
        {
            Mode = mode;
        }
        public static TravelMode Walking => new TravelMode("walking");
        public static TravelMode Bicycling => new TravelMode("bicycling");
    }
}