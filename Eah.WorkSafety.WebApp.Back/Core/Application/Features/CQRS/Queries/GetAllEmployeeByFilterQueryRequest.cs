using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllEmployeeByFilterQueryRequest : IRequest<List<EmployeeDto>>
    {
        public GetAllEmployeeByFilterQueryRequest(string filter)
        {
            Filter = filter;
        }

        public string Filter { get; }
    }
}
