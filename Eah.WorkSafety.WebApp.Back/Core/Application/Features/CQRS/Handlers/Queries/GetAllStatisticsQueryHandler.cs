using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllStatisticsQueryHandler : IRequestHandler<GetAllStatisticsQueryRequest, StatisticsDto>
    {
        private readonly IRepository<Employee> employeeRepository;
        private readonly IRepository<Accident> accidentRepository;
        private readonly IRepository<NearMiss> nearMisstRepository;
        private readonly IRepository<RiskAssessment> riskAssesmentRepository;
        private readonly IRepository<Inconsistency> inconsistencyRepository;
        private readonly IRepository<ContingencyPlan> contingencyPlanRepository;
        private readonly IRepository<PreventiveActivity> preventiveActivityRepository;

        public GetAllStatisticsQueryHandler(IRepository<Employee> employeeRepository, IRepository<Accident> accidentRepository, IRepository<NearMiss> nearMisstRepository, IRepository<RiskAssessment> riskAssesmentRepository, IRepository<Inconsistency> inconsistencyRepository, IRepository<ContingencyPlan> contingencyPlanRepository, IRepository<PreventiveActivity> preventiveActivityRepository)
        {
            this.employeeRepository = employeeRepository;
            this.accidentRepository = accidentRepository;
            this.nearMisstRepository = nearMisstRepository;
            this.riskAssesmentRepository = riskAssesmentRepository;
            this.inconsistencyRepository = inconsistencyRepository;
            this.contingencyPlanRepository = contingencyPlanRepository;
            this.preventiveActivityRepository = preventiveActivityRepository;
        }

        public async Task<StatisticsDto> Handle(GetAllStatisticsQueryRequest request, CancellationToken cancellationToken)
        {
            var countOfEmployee = await this.employeeRepository.GetAllCount();
            var countOfAccident = await this.accidentRepository.GetAllCount();
            Accident? lastAccident = await this.accidentRepository.GetByFilterAsync(x=>x.Date!);
            var countOfNearMisses = await this.nearMisstRepository.GetAllCount();
            var countOfRiskAssessments = await this.riskAssesmentRepository.GetAllCount();
            var countOfInconsistencies = await this.nearMisstRepository.GetAllCount();
            var countOfContingencyPlans = await this.contingencyPlanRepository.GetAllCount();
            var countOfPreventiveActivities = await this.preventiveActivityRepository.GetAllCount();
            var result = new StatisticsDto(countOfEmployee,countOfAccident, lastAccident.Date!, countOfNearMisses, countOfRiskAssessments, countOfInconsistencies, countOfContingencyPlans, countOfPreventiveActivities
                );
            return result;
        }
    }
}
