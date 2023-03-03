using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreatePreventiveActivityCommandHandler : IRequestHandler<CreatePreventiveActivityCommandRequest>
    {
        private readonly IRepository<PreventiveActivity> repository;

        public CreatePreventiveActivityCommandHandler(IRepository<PreventiveActivity> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreatePreventiveActivityCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(
                new PreventiveActivity
                {
                    Name = request.Name,
                    Information = request.Information,
                    SceneOfPreventiveActivity = request.SceneOfPreventiveActivity,
                    CreatorUserId = request.CreatorUserId,
                    PreventiveActivityDate = request.PreventiveActivityDate,
                    CreationDate = request.CreationDate,
                    Method = request.Method,
                    Deadline = request.Deadline,
                    RootCauseAnalysis = request.RootCauseAnalysis,
                    Status = request.Status,
                }
                );
            return Unit.Value;
        }
    }
}
