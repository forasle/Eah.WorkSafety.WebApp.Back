using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetUserQueryRequest:IRequest<UserDto>
    {
        public int Id { get; set; }

        public GetUserQueryRequest(int id)
        {
            Id = id;
        }
    }
}
