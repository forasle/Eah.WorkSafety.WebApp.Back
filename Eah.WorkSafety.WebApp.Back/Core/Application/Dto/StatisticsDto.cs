namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class StatisticsDto
    {

        public int NumberOfAccidents { get; set; }

        public DateTime TheDayOfLastAccident { get; set; }

        public int NumberOfNearMisses { get; set; }

        public int NumberOfRiskAssessments { get; set; }

        public int NumberOfInconsistencies { get; set; }

        public int NumberOfContingencyPlans { get; set; }

        public int NumberOfPreventiveActivities { get; set; }

    }
}
