using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class DeleteNearMissCommandHandler : IRequestHandler<DeleteNearMissCommandRequest>
    {
        private readonly IRepository<NearMiss> repository;

        public DeleteNearMissCommandHandler(IRepository<NearMiss> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteNearMissCommandRequest request, CancellationToken cancellationToken)
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
