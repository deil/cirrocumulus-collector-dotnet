using System;
using System.ServiceModel;

namespace Cirrocumulus.Collector
{
    [ServiceContract]
    public interface ICollectorService
    {
        [OperationContract]
        string SendRawEvent(string @event);
    }
}
