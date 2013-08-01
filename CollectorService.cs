using System;

namespace Cirrocumulus.Collector
{
    public class CollectorService : ICollectorService
    {
        public CollectorService()
        {
        }

        public string SendRawEvent(string @event)
        {
            Console.WriteLine(@event);
            return "oh";
        }
    }
}
