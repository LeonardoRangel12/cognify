using System;
using System.Threading.Tasks;
using Cognify.Core.Configuration;
using Cognify.Core.Interfaces;
using Cognify.Core.Models;

namespace Cognify.Core.Services
{
    public class SimulationService : ISimulationService
    {
        private readonly IMemoryFactory _memoryFactory;
        private readonly SimulationConfig _config;

        public SimulationService(IMemoryFactory memoryFactory)
        {
            _memoryFactory = memoryFactory;
            _config = SimulationConfig.Instance;
        }

        public async Task<Simulation> StartSimulation(Criminal criminal)
        {
            var memories = _memoryFactory.CreateMemorySequence(
                criminal.CrimeType, 
                _config.MemoriesPerSimulation);

            var simulation = new Simulation
            {
                Criminal = criminal,
                StartTime = DateTime.Now,
                ImplantedMemories = memories,
                IsCompleted = false
            };

            await Task.Delay(1000);
            return simulation;
        }

        public async Task<Simulation> MonitorSimulation(int simulationId)
        {
            await Task.Delay(500);
            return new Simulation { Id = simulationId };
        }

        public async Task<bool> EndSimulation(int simulationId)
        {
            await Task.Delay(500);
            return true;
        }
    }
}