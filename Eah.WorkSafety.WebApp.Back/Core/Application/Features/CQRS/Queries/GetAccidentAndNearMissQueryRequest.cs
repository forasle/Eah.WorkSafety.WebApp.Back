using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAccidentAndNearMissQueryRequest:IRequest<AccidentAndNearMissDto>
    {
        public int Id { get; set; }

        public GetAccidentAndNearMissQueryRequest(int id)
        {
            Id = id;
        }
    }
}
