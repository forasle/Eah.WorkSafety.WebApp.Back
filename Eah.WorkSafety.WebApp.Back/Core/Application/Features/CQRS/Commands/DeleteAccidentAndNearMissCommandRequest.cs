using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeleteAccidentAndNearMissCommandRequest:IRequest
    {
        public int Id { get; set; }
        public DeleteAccidentAndNearMissCommandRequest(int id)
        {
            Id = id;
        }
    }
}
