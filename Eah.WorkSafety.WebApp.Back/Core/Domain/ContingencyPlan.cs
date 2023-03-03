namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class ContingencyPlan
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int PlanNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Information { get; set; }

        public int CreatorUserId { get; set; }

        public User? User { get; set; }

        public DateTime ContingencyPlanDate { get; set; }

        public DateTime CreationDate { get; set; }

        public ContingencyPlan()
        {
        }
    }
}
