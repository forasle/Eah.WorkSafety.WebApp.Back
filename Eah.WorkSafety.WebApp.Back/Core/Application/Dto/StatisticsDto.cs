namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class StatisticsDto
    {

        public StatisticsDto(int numberOfEmployee, int numberOfAccidents, DateTime? lastAccidentDate, int numberOfNearMisses, int numberOfRiskAssessments, int numberOfInconsistencies, int numberOfContingencyPlans, int numberOfPreventiveActivities)
        {
            this.NumberOfEmployee = numberOfEmployee;
            this.NumberOfAccidents = numberOfAccidents;
            this.LastAccidentDate = lastAccidentDate;
            this.NumberOfNearMisses = numberOfNearMisses;
            this.NumberOfRiskAssessments = numberOfRiskAssessments;
            this.NumberOfInconsistencies = numberOfInconsistencies;
            this.NumberOfContingencyPlans = numberOfContingencyPlans;
            this.NumberOfPreventiveActivities = numberOfPreventiveActivities;
        }

        public int NumberOfEmployee { get; set; }
        public int NumberOfAccidents { get; set; }

        public DateTime? LastAccidentDate { get; set; }

        public int NumberOfNearMisses { get; set; }

        public int NumberOfRiskAssessments { get; set; }

        public int NumberOfInconsistencies { get; set; }

        public int NumberOfContingencyPlans { get; set; }

        public int NumberOfPreventiveActivities { get; set; }
    }
}
