using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;
using Velibs;

namespace VelibsClient
{
    public class MapsClient
    {
        private string APIKey;

        public MapsClient(string APIKey)
        {
            this.APIKey = APIKey;
        }

        public List<string> GetDirections(string origin, string destination)
        {

            string response = Requester.SendRequest("https://maps.googleapis.com/maps/api/directions/json?origin="+origin+"&destination="+destination+"&key="+APIKey);
            JObject json = JObject.Parse(response);
            List<JToken> steps = json["routes"].First["legs"].First["steps"].Children().ToList();
            List<string> route = new List<string>();
            foreach (JToken step in steps)
            {
                route.Add(step["html_instructions"].ToString());
            }

            return route;
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
}