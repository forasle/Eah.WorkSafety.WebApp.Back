using Eah.WorkSafety.WebApp.Back.Core.Application.Enums;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        public string? IdentificationNumber { get; set; }

        public string? RegistrationNumber { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public int? Age { get; set; }

        public Gender Gender { get; set; }

        public string? BirthPlace { get; set; }

        public string? Nationality { get; set; }

        public string? EducationStatus { get; set; }

        public string? RiskGroup { get; set; }

        public string? Title { get; set; }

        public string? Position { get; set; }

        public Department Department { get; set; }

        public DateTime? StartDateOfEmployment { get; set; }

        public string? Address { get; set; }

        public List<AffectedAccident>? AffectedAccident { get; set; }

        public List<AffectedNearMisses>? AffectedNearMisses { get; set; }

        public List<AffectedChronicDisease>? AffectedChronicDisease { get; set; }

        public List<AffectedOccupationDisease>? AffectedOccupationDisease { get; set; }

    }

    public class AffectedOccupationDisease
    {
        public int OccupationDiseaseId { get; set; }
    }

    public class AffectedChronicDisease
    {
        public int ChronicDiseaseId { get; set; }
    }

    public class AffectedAccident
    {
        public int AccidentId { get; set; }
    }
    public class AffectedNearMisses 
    {
        public int NearMissId { get; set; }
    }
}
