namespace Cognify.Core.Configuration
{
    public sealed class SimulationConfig
    {
        private static readonly Lazy<SimulationConfig> lazy = 
            new Lazy<SimulationConfig>(() => new SimulationConfig());

        public static SimulationConfig Instance { get { return lazy.Value; } }

        private SimulationConfig() { }

        public TimeSpan DefaultSimulationDuration { get; set; } = TimeSpan.FromMinutes(5);
        public int MemoriesPerSimulation { get; set; } = 5;
    }
}