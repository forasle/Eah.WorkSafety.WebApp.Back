namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class EmployeeDto
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

        public List<int>? Accidents { get; set; }
        public List<int>? NearMisses { get; set; }
        public List<int>? ChronicDisease { get; set; }
        public List<int>? OccupationDisease { get; set; }


    }
}
