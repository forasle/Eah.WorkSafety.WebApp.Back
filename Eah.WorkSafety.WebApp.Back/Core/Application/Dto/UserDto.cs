namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class UserDto
    {
        public string? Username { get; set; }

        public int RoleId { get; set; }


        public List<int>? Accidents { get; set; }

        public List<int>? Missions { get; set; }

        public List<int>? NearMisses { get; set; }

        public List<int>? RiskAssessments { get; set; }

        public List<int>? Inconsistencies { get; set; }

        public List<int>? ContingencyPlans { get; set; }

        public List<int>? PreventiveActivities { get; set; }

    }
}
