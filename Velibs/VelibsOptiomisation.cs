﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Velibs
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class VelibsOptimisation : IVelibsOptimisation
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string GetTraject(double lngOrigin, double latOrigin, double lngDestination, double latDestination)
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

            return output.ToString();
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
