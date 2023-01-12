using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllNearMissByKeyQueryRequest : IRequest<List<NearMissDto>>
    {
        public GetAllNearMissByKeyQueryRequest(PaginationFilter filter, string key)
        {
            Filter = filter;
            Key = key;
        }

        public PaginationFilter Filter { get; }
        public string Key { get; set; }
    }
}
