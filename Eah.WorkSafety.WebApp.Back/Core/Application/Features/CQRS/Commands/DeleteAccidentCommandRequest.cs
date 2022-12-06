using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeleteAccidentCommandRequest : IRequest
    {
        public int Id { get; set; }
        public DeleteAccidentCommandRequest(int id)
        {
            Id = id;
        }
    }
}
