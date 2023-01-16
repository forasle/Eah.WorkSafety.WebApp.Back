using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllOccupationDiseaseByKeyQueryRequest : IRequest<List<OccupationDiseaseDto>>
    {
        public GetAllOccupationDiseaseByKeyQueryRequest(PaginationFilter filter, string key)
        {
            Filter = filter;
            Key = key;
        }

        public PaginationFilter Filter { get; }
        public string Key { get; set; }
    }
}
