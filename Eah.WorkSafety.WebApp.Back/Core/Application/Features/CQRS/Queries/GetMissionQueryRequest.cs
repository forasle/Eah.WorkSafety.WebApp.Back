using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetMissionQueryRequest : IRequest<MissionDto>
    {
        public int Id { get; set; }

        public GetMissionQueryRequest(int id)
        {
            Id = id;
        }
    }
}
