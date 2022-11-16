using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateChronicDiseaseCommandHandler : IRequestHandler<CreateChronicDiseaseCommandRequest>
    {
        private readonly IRepository<ChronicDisease> repository;

        public CreateChronicDiseaseCommandHandler(IRepository<ChronicDisease> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateChronicDiseaseCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(
                new ChronicDisease
                {
                        Diagnosis = request.Diagnosis,
                        ReferenceNumber = request.ReferenceNumber,
                }
                );
            return Unit.Value;
        }
    }
}
