using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeletePreventiveActivityCommandRequest : IRequest
    {
        public int Id { get; set; }

        public DeletePreventiveActivityCommandRequest(int id)
        {
            Id = id;
        }
    }
}
