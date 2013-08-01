using System;
using System.ServiceModel.Description;
using System.ServiceModel;

namespace Cirrocumulus.Collector
{
    public class ServiceHost : IDisposable
    {
        public ServiceHost()
        {
        }

        public void Open()
        {
            if (_disposed)
                throw new ObjectDisposedException("this");

            _serviceHost = new System.ServiceModel.ServiceHost(typeof(CollectorService));
            _serviceHost.AddServiceEndpoint(typeof(ICollectorService), new NetTcpBinding(), new Uri("net.tcp://localhost:8129/collector"));
            _serviceHost.Open();
        }

        public void Close()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void IDisposable.Dispose()
        {
            Close();
        }

        ~ServiceHost()
        {
            Dispose(false);
        }

        private bool _disposed = false;
        private System.ServiceModel.ServiceHost _serviceHost;

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_serviceHost != null)
                {
                    ((IDisposable)_serviceHost).Dispose();
                }
            }

            _disposed = true;
        }
    }
}
