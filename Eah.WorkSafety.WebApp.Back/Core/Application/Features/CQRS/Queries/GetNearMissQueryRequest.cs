using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetNearMissQueryRequest : IRequest<NearMissDto>
    {
        public int Id { get; set; }

        public GetNearMissQueryRequest(int id)
        {
            Id = id;
        }
    }
}
