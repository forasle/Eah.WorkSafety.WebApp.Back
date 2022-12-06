using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateRiskAssessmentCommandHandler : IRequestHandler<UpdateRiskAssessmentCommandRequest>
    {
        private readonly IRepository<RiskAssessment> repository;

        public UpdateRiskAssessmentCommandHandler(IRepository<RiskAssessment> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateRiskAssessmentCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIdAsync(request.Id);
            if (updatedEntity != null)
            {
                updatedEntity.ReferenceNumber = request.ReferenceNumber;
                updatedEntity.Information = request.Information;
                updatedEntity.CreatorUserId = request.CreatorUserId;
                updatedEntity.Date = request.Date;
                updatedEntity.CreationTime = request.CreationTime;
                updatedEntity.Method = request.Method;

                await this.repository.UpdateAsync(updatedEntity);
            }

            return Unit.Value;

        }
    }
}
