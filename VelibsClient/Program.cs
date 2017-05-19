using System;
using System.Collections.Generic;
using VelibsClient.VelibsService;

namespace VelibsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            VelibsOptimisationClient client = new VelibsOptimisationClient();
            string[] response = client.GetDirections("Musée de l'Armée", "Le Palais Royal");
            foreach(string str in response){
                Console.Write(str+"\n");
            }
            Console.ReadLine();
        }
    }
}
