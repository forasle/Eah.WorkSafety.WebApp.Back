using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateOccupationDiseaseCommandHandler : IRequestHandler<CreateOccupationDiseaseCommandRequest>
    {
        private readonly IRepository<OccupationDisease> repository;

        public CreateOccupationDiseaseCommandHandler(IRepository<OccupationDisease> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateOccupationDiseaseCommandRequest request, CancellationToken cancellationToken)
        {
            var occupationDisease = new OccupationDisease
            {
                Diagnosis = request.Diagnosis,
                ReferenceNumber = request.ReferenceNumber,

            };
            if (request.OwnerEmployeeIdList != null)
            {
                foreach (var item in request.OwnerEmployeeIdList)
                {
                    occupationDisease.Employees.Add(new EmployeeOccupationDisease()
                    {
                        EmployeeId = item
                    });
                }
            }
            await this.repository.CreateAsync(occupationDisease);
            return Unit.Value;
        }
    }
}
