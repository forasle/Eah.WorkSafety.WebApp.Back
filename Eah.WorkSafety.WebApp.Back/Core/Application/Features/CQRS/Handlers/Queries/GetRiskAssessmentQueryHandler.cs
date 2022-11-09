using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetRiskAssessmentQueryHandler : IRequestHandler<GetRiskAssessmentQueryRequest, RiskAssessmentDto>
    {
        private readonly IRepository<RiskAssessment> repository;
        private readonly IMapper mapper;

        public GetRiskAssessmentQueryHandler(IRepository<RiskAssessment> repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<RiskAssessmentDto> Handle(GetRiskAssessmentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            return this.mapper.Map<RiskAssessmentDto>(data);
        }
    }
}
