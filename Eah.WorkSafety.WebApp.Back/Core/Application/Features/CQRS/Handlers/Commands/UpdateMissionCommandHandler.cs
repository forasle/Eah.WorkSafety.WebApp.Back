using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateMissionCommandHandler : IRequestHandler<UpdateMissionCommandRequest>
    {
        private readonly IRepository<Mission> repository;

        public UpdateMissionCommandHandler(IRepository<Mission> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateMissionCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIdAsync(request.Id);
            if(updatedEntity != null)
            {
                updatedEntity.Name = request.Name;
                updatedEntity.Department = request.Department;
                updatedEntity.AssignerUserId = request.AssignerUserId;
                updatedEntity.AssignedUserId = request.AssignedUserId;
                updatedEntity.Date = request.Date;
                updatedEntity.Deadline = request.Deadline;
                updatedEntity.Status = request.Status;

                await this.repository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;
        }
    }
}
