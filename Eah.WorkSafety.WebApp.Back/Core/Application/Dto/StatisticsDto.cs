namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class StatisticsDto
    {

        public StatisticsDto(int numberOfEmployee, int numberOfChronicDisease, int numberOfOccupationDisease, int numberOfAccidents, DateTime? lastAccidentDate, int numberOfNearMisses, int numberOfRiskAssessments, int numberOfInconsistencies, int numberOfContingencyPlans, int numberOfPreventiveActivities)
        {
            this.NumberOfEmployee = numberOfEmployee;
            this.NumberOfChronicDisease = numberOfChronicDisease;
            this.NumberOfOccupationDisease = numberOfOccupationDisease;
            this.NumberOfAccidents = numberOfAccidents;
            this.LastAccidentDate = lastAccidentDate;
            this.NumberOfNearMisses = numberOfNearMisses;
            this.NumberOfRiskAssessments = numberOfRiskAssessments;
            this.NumberOfInconsistencies = numberOfInconsistencies;
            this.NumberOfContingencyPlans = numberOfContingencyPlans;
            this.NumberOfPreventiveActivities = numberOfPreventiveActivities;
        }

        public int NumberOfEmployee { get; set; }

        public int NumberOfChronicDisease { get; set; }

        public int NumberOfOccupationDisease { get; set; }
        public int NumberOfAccidents { get; set; }

        public DateTime? LastAccidentDate { get; set; }

        public int NumberOfNearMisses { get; set; }

        public int NumberOfRiskAssessments { get; set; }

        public int NumberOfInconsistencies { get; set; }

        public int NumberOfContingencyPlans { get; set; }

        public int NumberOfPreventiveActivities { get; set; }
    }
}
