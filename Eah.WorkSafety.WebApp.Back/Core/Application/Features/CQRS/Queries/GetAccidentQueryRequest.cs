using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAccidentQueryRequest : IRequest<AccidentDto>
    {
        public int Id { get; set; }

        public GetAccidentQueryRequest(int id)
        {
            Id = id;
        }
    }
}
