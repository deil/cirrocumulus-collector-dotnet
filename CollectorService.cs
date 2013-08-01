using System;

namespace Cirrocumulus.Collector
{
    public class CollectorService : ICollectorService
    {
        public CollectorService()
        {
        }

        public bool SendRawEvent(DateTime time, string origin, string @event)
        {
            Console.WriteLine(@event);
            return true;
        }
    }
}
