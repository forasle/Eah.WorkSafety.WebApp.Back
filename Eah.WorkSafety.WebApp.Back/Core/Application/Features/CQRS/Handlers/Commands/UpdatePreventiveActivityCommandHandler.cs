using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdatePreventiveActivityCommandHandler : IRequestHandler<UpdatePreventiveActivityCommandRequest>
    {
        private readonly IRepository<PreventiveActivity> repository;

        public UpdatePreventiveActivityCommandHandler(IRepository<PreventiveActivity> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdatePreventiveActivityCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIdAsync(request.Id);
            if (updatedEntity != null)
            {
                updatedEntity.SceneOfPreventiveActivity = request.SceneOfPreventiveActivity;
                updatedEntity.Information = request.Information;
                updatedEntity.CreatorUserId = request.CreatorUserId;
                updatedEntity.PreventiveActivityDate = request.PreventiveActivityDate;
                updatedEntity.Method = request.Method;
                updatedEntity.RootCauseAnalysis = request.RootCauseAnalysis;
                
                await this.repository.UpdateAsync(updatedEntity);
            }

            return Unit.Value;

        }
    }
}
