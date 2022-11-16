using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateInconsistencyCommandHandler : IRequestHandler<CreateInconsistencyCommandRequest>
    {
        private readonly IRepository<Inconsistency> repository;

        public CreateInconsistencyCommandHandler(IRepository<Inconsistency> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateInconsistencyCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(new Inconsistency
            {
                ReferenceNumber = request.ReferenceNumber,
                Information = request.Information,
                Date = request.Date,
                RootCauseAnalysisRequirement = request.RootCauseAnalysisRequirement,
                Department = request.Department,
                Status = request.Status,
                RiskScore = request.RiskScore,
                CreatorUserId = request.CreatorUserId,
            });
            return Unit.Value;
        }
    }
}
