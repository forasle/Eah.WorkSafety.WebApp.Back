using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateContingencyPlanCommandHandler : IRequestHandler<CreateContingencyPlanCommandRequest>
    {
        private readonly IRepository<ContingencyPlan> repository;

        public CreateContingencyPlanCommandHandler(IRepository<ContingencyPlan> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateContingencyPlanCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(
                new ContingencyPlan
                {
                    Name = request.Name,
                    PlanNumber = request.PlanNumber,
                    ReferenceNumber = request.ReferenceNumber,
                    Information = request.Information,
                    CreatorUserId = request.CreatorUserId,
                    CreationDate = request.CreationDate,
                    ContingencyPlanDate = request.ContingencyPlanDate,
                }
                );
            return Unit.Value;
        }
    }
}
