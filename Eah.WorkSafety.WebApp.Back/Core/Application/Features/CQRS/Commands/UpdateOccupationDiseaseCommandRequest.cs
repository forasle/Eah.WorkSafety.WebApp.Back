using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class UpdateOccupationDiseaseCommandRequest:IRequest
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Diagnosis { get; set; }
        public List<UpdateAffectedEmployeeByOccupationDisease>? UpdateAffectedEmployeeByOccupationDisease { get; set; }
    }
    public class UpdateAffectedEmployeeByOccupationDisease
    {
        public int EmployeeId { get; set; }
    }
}
