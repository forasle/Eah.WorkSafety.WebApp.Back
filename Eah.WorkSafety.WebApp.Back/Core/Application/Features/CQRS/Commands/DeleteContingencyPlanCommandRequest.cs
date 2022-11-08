using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeleteContingencyPlanCommandRequest:IRequest
    {
        public int Id { get; set; }
        public DeleteContingencyPlanCommandRequest(int id)
        {
            Id = id;
        }
    }
}
