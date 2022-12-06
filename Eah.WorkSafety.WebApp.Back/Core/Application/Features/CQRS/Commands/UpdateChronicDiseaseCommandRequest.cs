using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class UpdateChronicDiseaseCommandRequest:IRequest
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Diagnosis { get; set; }
        public List<int>? OwnerEmployeeIdList { get; set; }
    }
}
