namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class AccidentAndNearMiss
    {
        public int Id { get; set; }

        public int AccidentNumber { get; set; }

        public string ReferenceNumber { get; set; }

        public string AccidentInfo { get; set; }

        public AppUser AccidentIdentifier { get; set; }

        public DateTime Date { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public int LostDays { get; set; }


    }
}
