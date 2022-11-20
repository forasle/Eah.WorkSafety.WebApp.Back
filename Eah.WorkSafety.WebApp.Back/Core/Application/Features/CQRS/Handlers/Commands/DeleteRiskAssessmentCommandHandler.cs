using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class DeleteRiskAssessmentCommandHandler : IRequestHandler<DeleteRiskAssessmentCommandRequest>
    {
        private readonly IRepository<RiskAssessment> repository;

        public DeleteRiskAssessmentCommandHandler(IRepository<RiskAssessment> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteRiskAssessmentCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedEntity = await this.repository.GetByIdAsync(request.Id);
            if (deletedEntity != null)
            {
                await this.repository.DeleteAsync(deletedEntity);
            }
            return Unit.Value;
        }
    }
}
