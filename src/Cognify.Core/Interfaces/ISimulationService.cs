using System.Threading.Tasks;
using Cognify.Core.Models;

namespace Cognify.Core.Interfaces
{
    public interface ISimulationService
    {
        Task<Simulation> StartSimulation(Criminal criminal);
        Task<Simulation> MonitorSimulation(int simulationId);
        Task<bool> EndSimulation(int simulationId);
    }
}