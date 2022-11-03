namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class AppUser
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public int AppRoleId { get; set; }

        public AppRole AppRole { get; set; }

        public List<AccidentNearMiss> AccidentNearMisses { get; set; }

        public List<RiskAssessment> RiskAssessments { get; set; }

        public List<Inconsistency> Inconsistencies { get; set; }

        public List<Mission> Missions { get; set; }

        public List<ContingencyPlan> ContingencyPlans { get; set; }

        public AppUser()
        {
            AppRole = new AppRole();
            AccidentNearMisses = new List<AccidentNearMiss>();
            RiskAssessments = new List<RiskAssessment>();
            Inconsistencies = new List<Inconsistency>();
            Missions = new List<Mission>();
            ContingencyPlans = new List<ContingencyPlan>();
        }
    }
}
