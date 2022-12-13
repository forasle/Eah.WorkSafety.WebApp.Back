using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllStatisticsQueryHandler : IRequestHandler<GetAllStatisticsQueryRequest, List<StatisticsDto>>
    {
        private readonly IRepository<Accident> accidentRepository;
        private readonly IRepository<NearMiss> nearMissRepository;
        private readonly IRepository<RiskAssessment> riskAssessmentRepository;
        private readonly IRepository<Inconsistency> inconsistencyRepository;
        private readonly IRepository<ContingencyPlan> contingencyPlanRepository;
        private readonly IRepository<PreventiveActivity> preventiveActivityRepository;

        public GetAllStatisticsQueryHandler(IRepository<Accident> accidentRepository, IRepository<NearMiss> nearMissRepository, IRepository<RiskAssessment> riskAssessmentRepository, IRepository<Inconsistency> inconsistencyRepository, IRepository<ContingencyPlan> contingencyPlanRepository, IRepository<PreventiveActivity> preventiveActivityRepository)
        {
            this.accidentRepository = accidentRepository;
            this.nearMissRepository = nearMissRepository;
            this.riskAssessmentRepository = riskAssessmentRepository;
            this.inconsistencyRepository = inconsistencyRepository;
            this.contingencyPlanRepository = contingencyPlanRepository;
            this.preventiveActivityRepository = preventiveActivityRepository;
        }

        public async Task<List<StatisticsDto>> Handle(GetAllStatisticsQueryRequest request, CancellationToken cancellationToken)
        {
            var numberOfAccidents = await accidentRepository.
        }
    }
}
