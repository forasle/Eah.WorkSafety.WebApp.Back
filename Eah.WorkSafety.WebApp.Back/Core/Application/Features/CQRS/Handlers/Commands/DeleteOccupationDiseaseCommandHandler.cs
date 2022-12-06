using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class DeleteOccupationDiseaseCommandHandler : IRequestHandler<DeleteOccupationDiseaseCommandRequest>
    {
        private readonly IRepository<OccupationDisease> repository;

        public DeleteOccupationDiseaseCommandHandler(IRepository<OccupationDisease> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteOccupationDiseaseCommandRequest request, CancellationToken cancellationToken)
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
