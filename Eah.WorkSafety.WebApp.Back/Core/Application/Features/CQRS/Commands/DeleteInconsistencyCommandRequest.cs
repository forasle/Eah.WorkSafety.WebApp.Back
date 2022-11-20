using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeleteInconsistencyCommandRequest:IRequest
    {
        public int Id { get; set; }

        public DeleteInconsistencyCommandRequest(int id)
        {
            Id = id;
        }
    }
}
