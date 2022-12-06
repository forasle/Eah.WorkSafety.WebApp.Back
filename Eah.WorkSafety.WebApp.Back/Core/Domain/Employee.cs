namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class Employee
    {
        public int Id { get; set; }

        public string? IdentificationNumber { get; set; }

        public string? RegistrationNumber { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Position { get; set; }

        public string? Department { get; set; }

        public DateTime? StartDateOfEmployment { get; set; }

        public string? Address { get; set; }

        public List<EmployeeAccident> Accidents { get; set; }

        public List<EmployeeNearMiss> NearMisses { get; set; }

        public List<EmployeeOccupationDisease> OccupationDiseases { get; set; }

        public List<EmployeeChronicDisease> ChronicDiseases { get; set; }

        public Employee()
        {
            Accidents= new List<EmployeeAccident>();
            NearMisses = new List<EmployeeNearMiss>();
            OccupationDiseases = new List<EmployeeOccupationDisease>();
            ChronicDiseases = new List<EmployeeChronicDisease>();
        }
    }
}
