using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateAccidentAndNearMissCommandHandler:IRequestHandler<UpdateAccidentAndNearmissCommandRequest>
    {
        private readonly IRepository<AccidentAndNearMiss> repository;

        public UpdateAccidentAndNearMissCommandHandler(IRepository<AccidentAndNearMiss> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateAccidentAndNearmissCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIdAsync(request.Id);
            if(updatedEntity !=null)
            {
                updatedEntity.AccidentNearMissNumber = request.AccidentNearMissNumber;
                updatedEntity.ReferenceNumber = request.ReferenceNumber;
                updatedEntity.AccidentNearMissInfo = request.AccidentNearMissInfo;
                updatedEntity.Date = request.Date;
                updatedEntity.RootCauseAnalysis = request.RootCauseAnalysis;
                updatedEntity.LostDays = request.LostDays;
                updatedEntity.IdentifierUserId = request.IdentifierUserId;
                updatedEntity.AccidentOrNearMissTypeId = request.AccidentOrNearMissTypeId;

                await this.repository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;

        }
    }
}
