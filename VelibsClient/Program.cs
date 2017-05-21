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

            Console.Write("Starting point address: ");
            string start = Console.ReadLine();
            Console.Write("Ending point address: ");
            string end = Console.ReadLine();
            
            Console.WriteLine();
            
            string[] response = client.GetDirections(start, end);
            foreach(string str in response){
                Console.WriteLine(str);
            }
            
            Console.WriteLine();
            Console.WriteLine("Press Enter to quit");
            
            Console.ReadLine();
        }
    }
}
