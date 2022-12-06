using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeleteNearMissCommandRequest:IRequest
    {
        public int Id { get; set; }

        public DeleteNearMissCommandRequest(int id)
        {
            Id = id;
        }
    }
}
