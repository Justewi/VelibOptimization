using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibsClientTCP.VelibsService;

namespace VelibsClientTCP
{
    class Program
    {
        static void Main(string[] args)
        {
            VelibsOptimisationClient client = new VelibsOptimisationClient("TCP");

            Console.Write("Starting point address: ");
            string start = Console.ReadLine();
            Console.Write("Ending point address: ");
            string end = Console.ReadLine();

            Console.WriteLine();

            string[] response = client.GetDirections(start, end);
            foreach (string str in response)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to quit");

            Console.ReadLine();
        }
    }
}
