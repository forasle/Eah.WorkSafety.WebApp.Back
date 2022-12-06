using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Eah.WorkSafety.WebApp.Back.Infrastructure.Tools;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class CheckUserQueryHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        private readonly IRepository<User> userRepository;
        private readonly IRepository<Role> roleRepository;

        public CheckUserQueryHandler(IRepository<User> userRepository, IRepository<Role> roleRepository)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();

            var user = await this.userRepository.GetByFilterAsync(x => x.Username == request.Username);

            if (user == null)
            {
                dto.IsExist = false;
            }
            else
            {
                if (user.Password != null && user.Username != null)
                {
                    if (Encryption.ConvertToDecrypt(user.Password) == request.Password)
                    {
                        dto.Username = user.Username;
                        dto.Id = user.Id;
                        dto.IsExist = true;
                        var role = await this.roleRepository.GetByFilterAsync(x => x.Id == user.RoleId);
                        if (role != null)
                        {
                            if (role.Definition != null)
                            {
                                dto.UserRole = role.Definition;
                            }

                        }

                    }
                }

            }
            return dto;



        }
    }
}
