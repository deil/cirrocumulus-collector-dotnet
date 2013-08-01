using System;
using Cirrocumulus.Collector;

namespace cirrocumuluscollectordotnet
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting collector service..");

            using (var host = new ServiceHost())
            {
                host.Open();
                Console.WriteLine("Press any key to stop.");
                Console.ReadKey();
            }

            Console.WriteLine("Bye.");
        }
    }
}
