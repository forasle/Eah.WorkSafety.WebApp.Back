namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class ChronicDisease
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Diagnosis { get; set; }

        public List<EmployeeChronicDisease>? Employees  { get; set; }

        public ChronicDisease()
        {
        }
    }
}
