namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class AccidentAndNearMissTypes
    {
        public int Id { get; set; }

        public string? Definition { get; set; }

        public List<AccidentAndNearMiss> AccidentNearMisses { get; set; }

        public AccidentAndNearMissTypes()
        {
            AccidentNearMisses = new List<AccidentAndNearMiss>();
        }
    }
}
