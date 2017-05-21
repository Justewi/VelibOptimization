using System;
using System.IO;
using System.Net;
using System.Threading;

namespace Velibs
{
    public class Requester
    {
        public static string SendRequest(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            return responseFromServer;
        }
    }
}