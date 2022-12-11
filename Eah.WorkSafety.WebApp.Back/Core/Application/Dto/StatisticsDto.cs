namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class StatisticsDto
    {

        public StatisticsDto(int numberOfAccidents, DateTime? lastAccidentDate, int numberOfNearMisses, int numberOfRiskAssessments, int numberOfInconsistencies, int numberOfContingencyPlans, int numberOfPreventiveActivities)
        {
            NumberOfAccidents = numberOfAccidents;
            LastAccidentDate = lastAccidentDate;
            NumberOfNearMisses = numberOfNearMisses;
            NumberOfRiskAssessments = numberOfRiskAssessments;
            NumberOfInconsistencies = numberOfInconsistencies;
            NumberOfContingencyPlans = numberOfContingencyPlans;
            NumberOfPreventiveActivities = numberOfPreventiveActivities;
        }

        public int NumberOfAccidents { get; set; }

        public DateTime? LastAccidentDate { get; set; }

        public int NumberOfNearMisses { get; set; }

        public int NumberOfRiskAssessments { get; set; }

        public int NumberOfInconsistencies { get; set; }

        public int NumberOfContingencyPlans { get; set; }

        public int NumberOfPreventiveActivities { get; set; }
    }
}
