using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class DeleteChronicDiseaseCommandHandler : IRequestHandler<DeleteChronicDiseaseCommandRequest>
    {
        private readonly IRepository<ChronicDisease> repository;

        public DeleteChronicDiseaseCommandHandler(IRepository<ChronicDisease> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteChronicDiseaseCommandRequest request, CancellationToken cancellationToken)
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
