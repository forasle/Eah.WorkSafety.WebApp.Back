using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetPreventiveActivityQueryRequest : IRequest<PreventiveActivityDto>
    {
        public int Id { get; set; }

        public GetPreventiveActivityQueryRequest(int id)
        {
            Id = id;
        }
    }
}
