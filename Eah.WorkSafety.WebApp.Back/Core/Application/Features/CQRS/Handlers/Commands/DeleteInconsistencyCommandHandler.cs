﻿using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class DeleteInconsistencyCommandHandler : IRequestHandler<DeleteInconsistencyCommandRequest>
    {
        private readonly IRepository<Inconsistency> repository;

        public DeleteInconsistencyCommandHandler(IRepository<Inconsistency> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteInconsistencyCommandRequest request, CancellationToken cancellationToken)
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
