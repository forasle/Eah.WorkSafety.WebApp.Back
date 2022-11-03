namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class AccidentNearMiss
    {
        public int Id { get; set; }

        public int AccidentNearMissNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? AccidentNearMissInfo { get; set; }


        public DateTime Date { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public int LostDays { get; set; }

        public AppUser? Identifier { get; set; }


        public int IdentifiedUserId { get; set; }

        public int AccidentOrNearMissTypeId { get; set; }

        public AccidentAndNearMissType AccidentAndNearMissType { get; set; }

        public AccidentNearMiss()
        {
            AccidentAndNearMissType = new AccidentAndNearMissType();
        }


    }
}
