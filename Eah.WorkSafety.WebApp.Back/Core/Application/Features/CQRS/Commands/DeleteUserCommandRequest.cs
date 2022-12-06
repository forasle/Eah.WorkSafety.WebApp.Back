using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeleteUserCommandRequest:IRequest
    {
        public int Id { get; set; }

        public DeleteUserCommandRequest(int id)
        {
            Id = id;
        }
    }
}
