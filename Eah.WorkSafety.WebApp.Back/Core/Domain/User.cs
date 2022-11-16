namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public UserRole? Role { get; set; }

        public List<UserMission>? Missions { get; set; }

        public List<RiskAssessment>? RiskAssessments { get; set; }

        public List<Accident>? Accidents { get; set; }

        public List<ContingencyPlan>? ContingencyPlans { get; set; }

        public List<NearMiss>? NearMisses { get; set; }

        public User()
        {

        }
    }
}
