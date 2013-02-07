namespace NServiceBus.Satellites.Config
{
    using Unicast.Transport;

    public class SatelliteContext
    {
        internal SatelliteContext()
        {
            Instance = null;
            Started = false;
            Transport = null;                        
        }
        
        public ITransport Transport { get; set; }
        public ISatellite Instance { get; set; }
        public bool Started { get; set; }        
    }
}