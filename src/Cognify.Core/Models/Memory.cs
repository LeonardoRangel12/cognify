namespace Cognify.Core.Models
{
    public class Memory
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public CrimeType TargetCrimeType { get; set; }
        public TimeSpan PerceivedDuration { get; set; }
        public string EmotionalImpact { get; set; }
    }
}