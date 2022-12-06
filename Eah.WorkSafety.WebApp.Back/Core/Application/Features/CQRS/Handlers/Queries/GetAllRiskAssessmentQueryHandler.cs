using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllRiskAssessmentQueryHandler : IRequestHandler<GetAllRiskAssessmentQueryRequest, List<RiskAssessmentDto>>
    {
        private readonly IRepository<RiskAssessment> repository;
        private readonly IMapper mapper;

        public GetAllRiskAssessmentQueryHandler(IRepository<RiskAssessment> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<RiskAssessmentDto>> Handle(GetAllRiskAssessmentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllAsync();
            return this.mapper.Map<List<RiskAssessmentDto>>(data);
        }
    }
}
