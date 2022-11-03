namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public int UserRoleId { get; set; }

        public UserRole UserRole { get; set; }

        public List<AccidentAndNearMiss> AccidentNearMisses { get; set; }

        public List<RiskAssessment> RiskAssessments { get; set; }

        public List<Inconsistency> Inconsistencies { get; set; }

        public List<ContingencyPlan> ContingencyPlans { get; set; }

        public List<UserMission> UserMissions { get; set; }

        public User()
        {
            UserRole = new UserRole();
            AccidentNearMisses = new List<AccidentAndNearMiss>();
            RiskAssessments = new List<RiskAssessment>();
            Inconsistencies = new List<Inconsistency>();
            ContingencyPlans = new List<ContingencyPlan>();
            UserMissions = new List<UserMission>();
        }
    }
}
