using System;
using Cognify.Core.Models;

namespace Cognify.Views
{
    public class ConsoleView : IView
    {
        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Bienvenido al Sistema Cognify de Rehabilitación Criminal");
            Console.WriteLine("====================================================");
        }

        public Criminal GetCriminalInformation()
        {
            Console.WriteLine("\nIngrese los datos del delincuente:");
            
            Console.Write("Nombre: ");
            var name = Console.ReadLine();

            Console.WriteLine("\nTipo de crimen:");
            Console.WriteLine("1. Violento");
            Console.WriteLine("2. Financiero");
            Console.WriteLine("3. Crimen de odio");
            Console.Write("Seleccione (1-3): ");
            
            var crimeType = Console.ReadLine() switch
            {
                "1" => CrimeType.Violent,
                "2" => CrimeType.Financial,
                "3" => CrimeType.HateCrime,
                _ => CrimeType.Violent
            };

            return new Criminal
            {
                Name = name,
                CrimeType = crimeType
            };
        }

        public bool GetRehabilitationChoice()
        {
            Console.WriteLine("\n¿Desea someterse a rehabilitación acelerada?");
            Console.Write("(S/N): ");
            var response = Console.ReadLine();
            return response?.ToUpper() == "S";
        }

        public void DisplaySimulationProgress(Simulation simulation)
        {
            Console.WriteLine("\nIniciando simulación...");
            Console.WriteLine($"Implantando {simulation.ImplantedMemories.Count} memorias...");
            // Aquí podrías agregar una barra de progreso
        }

        public void DisplayResults(Simulation simulation)
        {
            Console.WriteLine("\nSimulación completada");
            Console.WriteLine($"Tiempo transcurrido: {simulation.EndTime - simulation.StartTime}");
            Console.WriteLine("Memorias implantadas exitosamente");
        }
    }
}