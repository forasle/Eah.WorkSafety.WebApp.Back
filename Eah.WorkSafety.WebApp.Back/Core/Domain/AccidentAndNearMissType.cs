namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class AccidentAndNearMissType
    {
        public int Id { get; set; }

        public string? Definition { get; set; }

        public List<AccidentAndNearMiss> AccidentNearMisses { get; set; }

        public AccidentAndNearMissType()
        {
            AccidentNearMisses = new List<AccidentAndNearMiss>();
        }
    }
}
