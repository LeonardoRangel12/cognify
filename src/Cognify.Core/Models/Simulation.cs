namespace Cognify.Core.Models
{
    public class Simulation
    {
        public int Id { get; set; }
        public Criminal Criminal { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<Memory> ImplantedMemories { get; set; }
        public bool IsCompleted { get; set; }
        public string Results { get; set; }
    }
}