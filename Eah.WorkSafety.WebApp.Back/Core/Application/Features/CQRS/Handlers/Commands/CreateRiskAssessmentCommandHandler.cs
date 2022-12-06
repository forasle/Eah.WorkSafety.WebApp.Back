using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateRiskAssessmentCommandHandler : IRequestHandler<CreateRiskAssessmentCommandRequest>
    {
        private readonly IRepository<RiskAssessment> repository;

        public CreateRiskAssessmentCommandHandler(IRepository<RiskAssessment> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateRiskAssessmentCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(
                new RiskAssessment
                {
                    Name = request.Name,
                    Information = request.Information,
                    ReferenceNumber = request.ReferenceNumber,
                    CreatorUserId = request.CreatorUserId,
                    RevisionDate = request.RevisionDate,
                    Date = request.Date,
                    CreationTime = request.CreationTime,
                    Method = request.Method,
                }
                );
            return Unit.Value;
        }
    }
}
