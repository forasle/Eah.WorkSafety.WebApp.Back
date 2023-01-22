using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateChronicDiseaseCommandRequest:IRequest
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Diagnosis { get; set; }

        public List<CreateAffectedEmployeeByChronicDisease>? CreateAffectedEmployeeByChronicDiseaseId { get; set; }
    }
    public class CreateAffectedEmployeeByChronicDisease
    {
        public int EmployeeId { get; set; }
    }
}