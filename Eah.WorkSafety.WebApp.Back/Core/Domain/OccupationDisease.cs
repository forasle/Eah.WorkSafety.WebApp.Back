namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class OccupationDisease
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Diagnosis { get; set; }

        public List<EmployeeOccupationDisease>? Employees  { get; set; }

        public OccupationDisease()
        {
        }
    }
}
