namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class StatisticsDto
    {

        public int? NumberOfEmployee { get; set; }

        public double? AverageAgeOfEmployee { get; set; }

        public double? AverageDayOfWork { get; set; }

        public int? NumberOfChronicDisease { get; set; }

        public int? NumberOfOccupationDisease { get; set; }

        public int? NumberOfAccidents { get; set; }

        public DateTime? DayOfLastAccident { get; set; }

        public int? NumberOfNearMisses { get; set; }

        public int? NumberOfRiskAssessments { get; set; }

        public int? NumberOfInconsistencies { get; set; }

        public int? NumberOfContingencyPlans { get; set; }

        public int? NumberOfPreventiveActivities { get; set; }
    }
}
