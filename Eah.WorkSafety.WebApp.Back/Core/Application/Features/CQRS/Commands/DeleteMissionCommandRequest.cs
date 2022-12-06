using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeleteMissionCommandRequest:IRequest
    {
        public int Id { get; set; }

        public DeleteMissionCommandRequest(int id)
        {
            Id = id;
        }
    }
}
