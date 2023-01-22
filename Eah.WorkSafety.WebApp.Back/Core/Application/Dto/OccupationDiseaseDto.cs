using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class OccupationDiseaseDto
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Diagnosis { get; set; }

        public List<AffectedEmployeeByOccupationDisease>? AffectedEmployeeByOccupationDisease { get; set; }
    }
    public class AffectedEmployeeByOccupationDisease
    {
        public int EmployeeId { get; set; }
    }
}