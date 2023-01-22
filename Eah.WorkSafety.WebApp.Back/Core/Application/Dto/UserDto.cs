namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class UserDto
    {
        public string? Username { get; set; }

        public int RoleId { get; set; }


        public List<UserAddedAccident>? UserAddedAccidents { get; set; }

        public List<UserAddedMission>? UserAddedMissions { get; set; }

        public List<UserAddedNearMiss>? UserAddedNearMisses { get; set; }

        public List<UserAddedRiskAssessment>? UserAddedRiskAssessments { get; set; }

        public List<UserAddedInconsistency>? UserAddedInconsistencies { get; set; }

        public List<UserAddedContingencyPlan>? UserAddedContingencyPlans { get; set; }

        public List<UserAddedPreventiveActivity>? UserAddedPreventiveActivities { get; set; }

    }

    public class UserAddedNearMiss
    {
        public int NearMissId { get; set; }
    }

    public class UserAddedMission
    {
        public int MissionId { get; set; }
    }

    public class UserAddedAccident
    {
        public int AccidentId { get; set; }
    }
    public class UserAddedRiskAssessment 
    {
        public int RiskAssessmentId { get; set; }
    }
    public class UserAddedInconsistency 
    {
        public int InconsistencyId { get; set; }
    }

    public class UserAddedContingencyPlan 
    {
        public int ContingencyPlanId { get; set; }
    }

    public class UserAddedPreventiveActivity 
    {
        public int PreventiveActivityId { get; set; }
    }


    
}
