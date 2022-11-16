namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class Accident
    {
        public int Id { get; set; }

        public int AccidentNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? AccidentInfo { get; set; }

        public DateTime? Date { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public int LostDays { get; set; }

        public int CreatorUserId { get; set; }

        public User? User { get; set; }

        public List<EmployeeAccident> Employees { get; set; }

        public Accident()
        {
            Employees = new List<EmployeeAccident>();
        }


    }
}
