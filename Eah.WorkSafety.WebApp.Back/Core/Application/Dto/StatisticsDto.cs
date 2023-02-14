namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class StatisticsDto
    {

        public int? NumberOfEmployee { get; set; }

        public int NumberOfUser { get; set; }

        public double? AverageAgeOfEmployee { get; set; }

        public double? AverageDayOfWork { get; set; }

        public int? TotalLostDays { get; set; }
        public int? TotalEmployeeAccident { get; set; }
        public int? TotalLostDaysAccident { get; set; }
        public int? TotalNeedFirstAidAccident { get; set; }
        public int? TotalNeedFirstAidButNoLostDaysAccident { get; set; }

        public int? NumberOfChronicDisease { get; set; }

        public int? NumberOfOccupationDisease { get; set; }

        public int? NumberOfAccidents { get; set; }

        public DateTime? DayOfLastAccident { get; set; }

        public int? NumberOfNearMisses { get; set; }

        public int? NumberOfRiskAssessments { get; set; }

        public int? NumberOfInconsistencies { get; set; }

        public int? NumberOfContingencyPlans { get; set; }

        public int? NumberOfPreventiveActivities { get; set; }

        public int? NumberOfMissions { get; set; }

        public int? NumberOfEmployeeBelow16 { get; set; }

        public int? NumberOfEmployeeBetween16_18 { get; set; }

        public int? NumberOfEmployeeBetween19_25 { get; set; }

        public int? NumberOfEmployeeBetween26_45 { get; set; }

        public int? NumberOfEmployeeBetween46_60 { get; set; }

        public int? NumberOfEmployeeAbove60 { get; set; }

        public int? NumberOfEmployeeByDepartment { get; set; }

        public int numberOfMaleEmployee { get; set; }

        public int? NumberOfFemaleEmployee { get; set; }

        public int? NumberOfUnspecifiedEmployee { get; set; }

        public int? NumberOfRootCauseAnalysisRequirementForAccident { get; set; }

        public int? NumberOfRootCauseAnalysisRequirementForNearMiss { get; set; }

        public int? NumberOfEmployeeWhoHadAnAccident { get; set; }

        public int? NumberOfAccidentWhichNeedsFirstAid { get; set; }

        public int? NumberOfAccidentWhichHasGotLostDay { get; set; }

        public int? NumberOfLostDays { get; set; }

        public int? NumberOfEmployeeWhoHadANearMiss { get; set; }

        public int? NumberOfNearMissWhichNeedsFirstAid { get; set; }

        public int? NumberOfNearMissWhichHasGotLostDay { get; set; }

        public int? TotalNeedFirstAidNearMiss { get; set; }

        public int? TotalNeedFirstAidButNoLostDaysNearMiss { get; set; }

    }
}
