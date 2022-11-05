namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class AccidentAndNearMiss
    {
        public int Id { get; set; }

        public int AccidentNearMissNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? AccidentNearMissInfo { get; set; }

        public DateTime? Date { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public int LostDays { get; set; }

        public User Identifier { get; set; }


        public int IdentifiedUserId { get; set; }

        public int AccidentOrNearMissTypeId { get; set; }

        public AccidentAndNearMissTypes AccidentAndNearMissType { get; set; }


        public List<PersonAccidentAndNearMiss> PersonAccidentAndNearMisses { get; set; }

        public AccidentAndNearMiss()
        {
            AccidentAndNearMissType = new AccidentAndNearMissTypes();
            PersonAccidentAndNearMisses = new List<PersonAccidentAndNearMiss>();
            Identifier = new User();
        }


    }
}
