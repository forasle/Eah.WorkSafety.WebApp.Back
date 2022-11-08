using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateInconsistencyCommandHandler : IRequestHandler<UpdateInconsistencyCommandRequest>
    {
        private readonly IRepository<Inconsistency> repository;

        public UpdateInconsistencyCommandHandler(IRepository<Inconsistency> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateInconsistencyCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIdAsync(request.Id);
            if (updatedEntity != null)
            {
                updatedEntity.ReferenceNumber = request.ReferenceNumber;
                updatedEntity.Information = request.Information;
                updatedEntity.IdentifierUserId = request.IdentifierUserId;
                updatedEntity.Date = request.Date;
                updatedEntity.RootCauseAnalysisRequirement = request.RootCauseAnalysisRequirement;
                updatedEntity.Department = request.Department;
                updatedEntity.Status = request.Status;
                updatedEntity.RiskScore = request.RiskScore;

                await this.repository.UpdateAsync(updatedEntity);
            }

            return Unit.Value;

        }
    }
}
