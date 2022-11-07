
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
            var updatedProduct = await this.repository.GetByIdAsync(request.Id);
            if (updatedProduct != null)
            {
                updatedProduct.IdentificationNumber = request.IdentificationNumber;
                updatedProduct.RegistrationNumber = request.RegistrationNumber;
                updatedProduct.Name = request.Name;
                updatedProduct.Surname = request.Surname;
                updatedProduct.Position = request.Position;
                updatedProduct.Department = request.Department;
                updatedProduct.StartDateOfEmployment = request.StartDateOfEmployment;
                updatedProduct.Address = request.Address;

                await this.repository.UpdateAsync(updatedProduct);
            }
            return Unit.Value;
           
        }
    }
}
