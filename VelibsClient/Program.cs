using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VelibsClient
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder output = new StringBuilder();


            WebRequest request = WebRequest.Create(
                "http://www.velib.paris/service/carto");
            // If required by the server, set the credentials.
            // request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            //Données a parser




            reader.Close();
            response.Close();



            Console.WriteLine("Voulez vous quitter ? ");
            Console.ReadLine();
        }
    }
}
