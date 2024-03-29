﻿using Eah.WorkSafety.WebApp.Back.Core.Application.Enums;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Eah.WorkSafety.WebApp.Back.Infrastructure.Tools;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest>
    {
        private readonly IRepository<User> repository;

        public RegisterUserCommandHandler(IRepository<User> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
            if(request.UserName !=null && request.Password != null)
            {
                await this.repository.CreateAsync(new User
                {
                    Username = request.UserName,
                    Password = Encryption.ConvertToEncrypt(request.Password),
                    RoleId = (int)UserRoleType.Visitor,
                });
            }
            return Unit.Value;
        }
    }
}
