using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllChronicDiseaseQueryRequest : IRequest<List<ChronicDiseaseDto>> 
    {
        public GetAllChronicDiseaseQueryRequest(PaginationFilter filter)
    {
        Filter = filter;
    }

    public PaginationFilter Filter { get; }
    }
}