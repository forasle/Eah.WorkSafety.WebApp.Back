
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommandRequest>
    {
        private readonly IRepository<Person> repository;

        public UpdatePersonCommandHandler(IRepository<Person> repository)
        {
            this.repository = repository;
        }
        public async Task<Unit> Handle(UpdatePersonCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIdAsync(request.Id);
            if (updatedEntity != null)
            {
                updatedEntity.IdentificationNumber = request.IdentificationNumber;
                updatedEntity.RegistrationNumber = request.RegistrationNumber;
                updatedEntity.Name = request.Name;
                updatedEntity.Surname = request.Surname;
                updatedEntity.Position = request.Position;
                updatedEntity.Department = request.Department;
                updatedEntity.StartDateOfEmployment = request.StartDateOfEmployment;
                updatedEntity.Address = request.Address;

                await this.repository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;
           
        }
    }
}
