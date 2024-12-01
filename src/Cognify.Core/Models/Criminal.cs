namespace Cognify.Core.Models
{
    public class Criminal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CrimeType CrimeType { get; set; }
        public bool AcceptedAcceleratedRehab { get; set; }
        public List<Memory> ImplantedMemories { get; set; } = new List<Memory>();
    }
}