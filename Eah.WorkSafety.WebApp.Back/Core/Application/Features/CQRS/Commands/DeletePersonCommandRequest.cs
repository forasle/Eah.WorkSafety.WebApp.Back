using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeletePersonCommandRequest:IRequest
    {
        public int Id { get; set; }

        public DeletePersonCommandRequest(int id)
        {
            Id = id;
        }
    }
}
