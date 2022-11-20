using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeleteEmployeeCommandRequest:IRequest
    {
        public int Id { get; set; }

        public DeleteEmployeeCommandRequest(int id)
        {
            Id = id;
        }
    }
}
