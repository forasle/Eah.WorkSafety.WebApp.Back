using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateNearMissCommandHandler : IRequestHandler<UpdateNearmissCommandRequest>
    {
        private readonly IRepository<NearMiss> repository;

        public UpdateNearMissCommandHandler(IRepository<NearMiss> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateNearmissCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIdAsync(request.Id);
            if (updatedEntity != null)
            {
                updatedEntity.NearMissNumber = request.NearMissNumber;
                updatedEntity.ReferenceNumber = request.ReferenceNumber;
                updatedEntity.NearMissInfo = request.NearMissInfo;
                updatedEntity.Date = request.Date;
                updatedEntity.RootCauseAnalysis = request.RootCauseAnalysis;
                updatedEntity.CreatorUserId = request.CreatorUserId;
                var employees = new List<EmployeeNearMiss>();
                if (request.AffectedEmployeeIdWithLostDaysList != null)
                {
                    foreach (var item in request.AffectedEmployeeIdWithLostDaysList)
                    {
                        employees.Add(new EmployeeNearMiss() { EmployeeId = item.Key,LostDays = item.Value });
                    }
                }
                updatedEntity.Employees = employees;

                await this.repository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;

        }
    }
}
