using Cognify.Core.Models;

namespace Cognify.Views
{
    public interface IView
    {
        void DisplayWelcomeMessage();
        Criminal GetCriminalInformation();
        bool GetRehabilitationChoice();
        void DisplaySimulationProgress(Simulation simulation);
        void DisplayResults(Simulation simulation);
    }
}
