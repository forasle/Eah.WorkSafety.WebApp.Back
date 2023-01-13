using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllPreventiveActivityByKeyQueryRequest : IRequest<List<PreventiveActivityDto>>
    {
        public GetAllPreventiveActivityByKeyQueryRequest(PaginationFilter filter, string key)
        {
            Filter = filter;
            Key = key;
        }

        public PaginationFilter Filter { get; }
        public string Key { get; set; }
    }
}
