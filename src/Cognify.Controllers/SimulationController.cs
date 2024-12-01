using System.Threading.Tasks;
using Cognify.Core.Interfaces;
using Cognify.Core.Models;
using Cognify.Views;
namespace Cognify.Controllers
{
    public class SimulationController
    {
        private readonly ISimulationService _simulationService;
        private readonly IView _view;

        public SimulationController(ISimulationService simulationService, IView view)
        {
            _simulationService = simulationService;
            _view = view;
        }

        public async Task RunSimulation()
        {
            _view.DisplayWelcomeMessage();
            var criminal = _view.GetCriminalInformation();
            
            if (_view.GetRehabilitationChoice())
            {
                var simulation = await _simulationService.StartSimulation(criminal);
                _view.DisplaySimulationProgress(simulation);
                
                await _simulationService.EndSimulation(simulation.Id);
                _view.DisplayResults(simulation);
            }
        }
    }
}