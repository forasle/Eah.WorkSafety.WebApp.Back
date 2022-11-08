using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetInconsistencyQueryRequest:IRequest<InconsistencyDto>
    {
        public int Id { get; set; }

        public GetInconsistencyQueryRequest(int id)
        {
            Id = id;
        }
    }
}
