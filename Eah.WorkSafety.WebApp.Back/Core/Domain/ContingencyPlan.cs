namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class ContingencyPlan
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int PlanNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Information { get; set; }

        public User Identifier { get; set; }

        public int IdentifiedUserId { get; set; }

        public DateTime Date { get; set; }

        public DateTime CreationTime { get; set; }

        public ContingencyPlan()
        {
            Identifier = new User();
        }
    }
}
