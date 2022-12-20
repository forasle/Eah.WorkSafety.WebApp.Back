using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllEmployeeQueryRequest : IRequest<List<EmployeeDto>>
    {
        public GetAllEmployeeQueryRequest(PaginationFilter filter)
        {
            Filter = filter;
        }

        public PaginationFilter Filter { get; }
    }
}
