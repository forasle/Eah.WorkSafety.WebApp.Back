using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateContingencyPlanCommandHandler : IRequestHandler<UpdateContingencyPlanCommandRequest>
    {
        private readonly IRepository<ContingencyPlan> repository;

        public UpdateContingencyPlanCommandHandler(IRepository<ContingencyPlan> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateContingencyPlanCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIdAsync(request.Id);
            if (updatedEntity != null) 
            { 
                updatedEntity.Name = request.Name;
                updatedEntity.PlanNumber = request.PlanNumber;
                updatedEntity.ReferenceNumber = request.ReferenceNumber;
                updatedEntity.Information = request.Information;
                updatedEntity.IdentifierUserId = request.IdentifierUserId;
                updatedEntity.Date = request.Date;
                updatedEntity.CreationTime = request.CreationTime;
                await this.repository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;
        }
    }
}
