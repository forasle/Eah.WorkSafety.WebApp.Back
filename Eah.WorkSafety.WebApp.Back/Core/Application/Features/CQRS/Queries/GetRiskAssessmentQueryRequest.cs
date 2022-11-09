using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetRiskAssessmentQueryRequest:IRequest<RiskAssessmentDto>
    {
        public int Id { get; set; }

        public GetRiskAssessmentQueryRequest(int id)
        {
            Id = id;
        }
    }
}
