using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;

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

            WebRequest request = WebRequest.Create(
                "https://maps.googleapis.com/maps/api/directions/json?origin="+origin+"&destination="+destination+"&key="+APIKey);

            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();

            JObject json = JObject.Parse(responseFromServer);
            List<JToken> steps = json["routes"].First["legs"].First["steps"].Children().ToList();
            List<string> route = new List<string>();
            foreach (JToken step in steps)
            {
                route.Add(step["html_instructions"].ToString());
            }

            return route;
        }
    }
}