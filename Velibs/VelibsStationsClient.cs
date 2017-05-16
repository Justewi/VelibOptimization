using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;
using Velibs;

namespace Velibs
{
    public class VelibsStationsClient
    {
        private Dictionary<int,Station> _stations;

        public VelibsStationsClient()
        {
            _stations = GetStations();
        }

        private static Dictionary<int,Station> GetStations()
        {
            WebRequest request = WebRequest.Create("http://www.velib.paris/service/carto");
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(responseFromServer);
            XmlNodeList markers = doc.DocumentElement.FirstChild.ChildNodes;
            Dictionary<int,Station> stations = new Dictionary<int, Station>();
            foreach (XmlNode marker in markers)
            {
                stations.Add(Convert.ToInt32(marker.Attributes["number"].Value),new Station(marker));
            }
            return stations;
        }

    }
}