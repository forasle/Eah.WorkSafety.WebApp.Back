using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetEmployeeQueryRequest : IRequest<EmployeeDto>
    {
        public int Id { get; set; }

        public GetEmployeeQueryRequest(int id)
        {
            Id = id;
        }
    }
}
