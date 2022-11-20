using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateOccupationDiseaseCommandHandler : IRequestHandler<UpdateOccupationDiseaseCommandRequest>
    {
        private readonly IRepository<OccupationDisease> repository;

        public UpdateOccupationDiseaseCommandHandler(IRepository<OccupationDisease> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateOccupationDiseaseCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIdAsync(request.Id);
            if (updatedEntity != null)
            {
                updatedEntity.ReferenceNumber = request.ReferenceNumber;
                updatedEntity.Diagnosis = request.Diagnosis;

             
                var employees = new List<EmployeeOccupationDisease>();
                if (request.OwnerEmployeeIdList != null)
                {
                    foreach (var id in request.OwnerEmployeeIdList)
                    {
                        employees.Add(new EmployeeOccupationDisease() { EmployeeId = id });
                    }
                }
                updatedEntity.Employees = employees;

                await this.repository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;

        }
    }
}
