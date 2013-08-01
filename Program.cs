using System;
using Cirrocumulus.Collector;

namespace cirrocumuluscollectordotnet
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var host = new ServiceHost())
            {
                host.Open();
                Console.ReadKey();
            }

            return;
        }
    }
}
