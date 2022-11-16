using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommandRequest>
    {
        private readonly IRepository<Employee> repository;

        public CreateEmployeeCommandHandler(IRepository<Employee> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(
                new Employee
                {
                    IdentificationNumber = request.IdentificationNumber,
                    RegistrationNumber = request.RegistrationNumber,
                    Name = request.Name,
                    Surname = request.Surname,
                    Position = request.Position,
                    Department = request.Department,
                    StartDateOfEmployment = request.StartDateOfEmployment,
                    Address = request.Address
                }
                );
            return Unit.Value;
        }
    }
}
