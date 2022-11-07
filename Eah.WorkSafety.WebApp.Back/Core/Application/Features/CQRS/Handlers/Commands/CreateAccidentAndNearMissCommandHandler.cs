using Eah.WorkSafety.WebApp.Back.Core.Application.Enums;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateAccidentAndNearMissCommandHandler : IRequestHandler<CreateAccidentAndNearMissCommandRequest>
    {
        private readonly IRepository<AccidentAndNearMiss> repository;

        public CreateAccidentAndNearMissCommandHandler(IRepository<AccidentAndNearMiss> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateAccidentAndNearMissCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(new AccidentAndNearMiss
            {
                AccidentNearMissNumber = request.AccidentNearMissNumber,
                ReferenceNumber = request.ReferenceNumber,
                AccidentNearMissInfo = request.AccidentNearMissInfo,
                Date = request.Date,
                RootCauseAnalysis = request.RootCauseAnalysis,
                LostDays = request.LostDays,
                IdentifierUserId = request.IdentifierUserId,
                AccidentOrNearMissTypeId = request.AccidentOrNearMissTypeId
            });
            return Unit.Value;
        }
    }
}
