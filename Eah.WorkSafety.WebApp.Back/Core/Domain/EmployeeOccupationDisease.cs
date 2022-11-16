namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class EmployeeOccupationDisease
    {
        public int EmployeeId { get; set; }

        public int OccupationDiseaseId { get; set; }
        public Employee? Employee { get; set; }

        public OccupationDisease? OccupationDisease { get; set; }

        public EmployeeOccupationDisease()
        {
        }
    }
}
