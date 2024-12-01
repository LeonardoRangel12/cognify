using System;
using System.Threading.Tasks;
using Cognify.Controllers;
using Cognify.Core.Services;
using Cognify.Views;

namespace Cognify.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Configurar servicios
            var memoryFactory = new MemoryFactory();
            var simulationService = new SimulationService(memoryFactory);
            var view = new ConsoleView();
            
            var controller = new SimulationController(simulationService, view);
            
            // Ejecutar simulación
            await controller.RunSimulation();

            System.Console.WriteLine("\nPresione cualquier tecla para salir...");
            System.Console.ReadKey();
        }
    }
}