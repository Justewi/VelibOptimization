using System;
using VelibsClient.VelibsService;

namespace VelibsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            VelibsOptimisationClient client = new VelibsOptimisationClient();
            string response = client.GetDirections("Musée de l'Armée", "Le Palais Royal");
            Console.Write(response);
            Console.ReadLine();
        }
    }
}
