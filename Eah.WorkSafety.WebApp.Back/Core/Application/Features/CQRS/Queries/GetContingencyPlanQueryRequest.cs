using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetContingencyPlanQueryRequest:IRequest<ContingencyPlanDto>
    {
        public int Id { get; set; }

        public GetContingencyPlanQueryRequest(int id)
        {
            Id = id;
        }
    }
}
