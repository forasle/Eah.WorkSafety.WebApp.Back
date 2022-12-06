using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class DeleteContingenyPlanCommandHandler : IRequestHandler<DeleteContingencyPlanCommandRequest>
    {
        private readonly IRepository<ContingencyPlan> repository;

        public DeleteContingenyPlanCommandHandler(IRepository<ContingencyPlan> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteContingencyPlanCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedEntity = await this.repository.GetByIdAsync(request.Id);
            if(deletedEntity != null)
            {
                await this.repository.DeleteAsync(deletedEntity);
            }
            return Unit.Value;
        }
    }
}
