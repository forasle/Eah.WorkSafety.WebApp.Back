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
        private readonly IRepository<EmployeeChronicDisease> employeeChronicDiseaseRepository;
        private readonly IRepository<EmployeeOccupationDisease> employeeOccupationDiseaseRepository;
        private readonly IRepository<Accident> accidentRepository;
        private readonly IRepository<NearMiss> nearMisstRepository;
        private readonly IRepository<RiskAssessment> riskAssesmentRepository;
        private readonly IRepository<Inconsistency> inconsistencyRepository;
        private readonly IRepository<ContingencyPlan> contingencyPlanRepository;
        private readonly IRepository<PreventiveActivity> preventiveActivityRepository;

        public GetAllStatisticsQueryHandler(IRepository<Employee> employeeRepository, IRepository<EmployeeChronicDisease> employeeChronicDiseaseRepository, IRepository<EmployeeOccupationDisease> employeeOccupationDiseaseRepository, IRepository<Accident> accidentRepository, IRepository<NearMiss> nearMisstRepository, IRepository<RiskAssessment> riskAssesmentRepository, IRepository<Inconsistency> inconsistencyRepository, IRepository<ContingencyPlan> contingencyPlanRepository, IRepository<PreventiveActivity> preventiveActivityRepository)
        {
            this.employeeRepository = employeeRepository;
            this.employeeChronicDiseaseRepository = employeeChronicDiseaseRepository;
            this.employeeOccupationDiseaseRepository = employeeOccupationDiseaseRepository;
            this.accidentRepository = accidentRepository;
            this.nearMisstRepository = nearMisstRepository;
            this.riskAssesmentRepository = riskAssesmentRepository;
            this.inconsistencyRepository = inconsistencyRepository;
            this.contingencyPlanRepository = contingencyPlanRepository;
            this.preventiveActivityRepository = preventiveActivityRepository;
        }

        public async Task<StatisticsDto> Handle(GetAllStatisticsQueryRequest request, CancellationToken cancellationToken)
        {
            int countOfEmployee = await this.employeeRepository.GetAllCountAsync();
            double? avarageAgeOfEmployee = await this.employeeRepository.GetAverageAsync(x=>x.Age !=null,x=> x.Age);

            int countOfEmployeeChronicDisease = await this.employeeChronicDiseaseRepository.GetAllCountAsync();
            int countOfemployeeOccupationDisease = await this.employeeOccupationDiseaseRepository.GetAllCountAsync();
            int countOfAccident = await this.accidentRepository.GetAllCountAsync();
            Accident? lastAccident = await this.accidentRepository.GetByFilterAsync(x => x.Date!);
            int countOfNearMisses = await this.nearMisstRepository.GetAllCountAsync();
            int countOfRiskAssessments = await this.riskAssesmentRepository.GetAllCountAsync();
            int countOfInconsistencies = await this.inconsistencyRepository.GetAllCountAsync();
            int countOfContingencyPlans = await this.contingencyPlanRepository.GetAllCountAsync();
            int countOfPreventiveActivities = await this.preventiveActivityRepository.GetAllCountAsync();



            return new StatisticsDto(countOfEmployee, countOfEmployeeChronicDisease, countOfemployeeOccupationDisease, countOfAccident, lastAccident!.Date, countOfNearMisses, countOfRiskAssessments, countOfInconsistencies, countOfContingencyPlans, countOfPreventiveActivities);

        }

    }
}
