﻿using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateMissionCommandHandler : IRequestHandler<CreateMissionCommandRequest>
    {
        private readonly IRepository<Mission> repository;

        public CreateMissionCommandHandler(IRepository<Mission> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateMissionCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(new Mission
            {
                Name = request.Name,
                Department = request.Department,
                AssignedUserId = request.AssignedUserId,
                AssignerUserId = request.AssignerUserId,
                Date = request.Date,
                Deadline = request.Deadline,
                Status = request.Status
            }) ;
            return Unit.Value;
        }
    }
}