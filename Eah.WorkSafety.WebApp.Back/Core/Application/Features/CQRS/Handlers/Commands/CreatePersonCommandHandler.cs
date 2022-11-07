using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommandRequest>
    {
        private readonly IRepository<Person> repository;

        public CreatePersonCommandHandler(IRepository<Person> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreatePersonCommandRequest request, CancellationToken cancellationToken)
        {
           await this.repository.CreateAsync(new Person
            {
                IdentificationNumber = request.IdentificationNumber,
                RegistrationNumber = request.RegistrationNumber,
                Name = request.Name,
                Surname = request.Surname,
                Position = request.Position,
                Department = request.Department,
                StartDateOfEmployment = request.StartDateOfEmployment,
                Address = request.Address
            });

            return Unit.Value;
        }
    }
}
