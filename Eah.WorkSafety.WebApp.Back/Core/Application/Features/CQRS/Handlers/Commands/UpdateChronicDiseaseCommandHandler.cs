using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateChronicDiseaseCommandHandler : IRequestHandler<UpdateChronicDiseaseCommandRequest>
    {
        private readonly IRepository<ChronicDisease> repository;

        public UpdateChronicDiseaseCommandHandler(IRepository<ChronicDisease> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateChronicDiseaseCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIdAsync(request.Id);
            if (updatedEntity != null)
            {
                updatedEntity.ReferenceNumber = request.ReferenceNumber;
                updatedEntity.Diagnosis = request.Diagnosis;

             
                var employees = new List<EmployeeChronicDisease>();
                if (request.UpdateAffectedEmployeeByChronicDisease != null)
                {
                    foreach (var item in request.UpdateAffectedEmployeeByChronicDisease)
                    {
                        employees.Add(new EmployeeChronicDisease() { EmployeeId = item.EmployeeId });
                    }
                }
                updatedEntity.Employees = employees;

                await this.repository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;

        }
    }
}
