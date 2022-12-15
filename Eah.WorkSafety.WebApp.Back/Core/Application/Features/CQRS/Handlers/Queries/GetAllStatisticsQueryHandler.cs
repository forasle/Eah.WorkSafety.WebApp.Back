using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllStatisticsQueryHandler : IRequestHandler<GetAllStatisticsQueryRequest, StatisticsDto>
    {
        private readonly IRepository<Employee> employeeRepository;
        private readonly IRepository<EmployeeChronicDisease> employeeChronicDiseaseRepository;
        private readonly IRepository<EmployeeOccupationDisease> employeeOccupationDiseaseRepository;
        private readonly IRepository<EmployeeAccident> employeeAccidentRepository;
        private readonly IRepository<EmployeeNearMiss> employeeNearMissRepository;
        private readonly IRepository<Accident> accidentRepository;
        private readonly IRepository<NearMiss> nearMissRepository;
        private readonly IRepository<RiskAssessment> riskAssessmentRepository;
        private readonly IRepository<Inconsistency> inconsistencyRepository;
        private readonly IRepository<ContingencyPlan> contingencyPlanRepository;
        private readonly IRepository<PreventiveActivity> preventiveActivityRepository;

        public GetAllStatisticsQueryHandler(IRepository<Employee> employeeRepository, IRepository<EmployeeChronicDisease> employeeChronicDiseaseRepository, IRepository<EmployeeOccupationDisease> employeeOccupationDiseaseRepository, IRepository<EmployeeAccident> employeeAccidentRepository, IRepository<EmployeeNearMiss> employeeNearMissRepository, IRepository<Accident> accidentRepository, IRepository<NearMiss> nearMissRepository, IRepository<RiskAssessment> riskAssessmentRepository, IRepository<Inconsistency> inconsistencyRepository, IRepository<ContingencyPlan> contingencyPlanRepository, IRepository<PreventiveActivity> preventiveActivityRepository)
        {
            this.employeeRepository = employeeRepository;
            this.employeeChronicDiseaseRepository = employeeChronicDiseaseRepository;
            this.employeeOccupationDiseaseRepository = employeeOccupationDiseaseRepository;
            this.employeeAccidentRepository = employeeAccidentRepository;
            this.employeeNearMissRepository = employeeNearMissRepository;
            this.accidentRepository = accidentRepository;
            this.nearMissRepository = nearMissRepository;
            this.riskAssessmentRepository = riskAssessmentRepository;
            this.inconsistencyRepository = inconsistencyRepository;
            this.contingencyPlanRepository = contingencyPlanRepository;
            this.preventiveActivityRepository = preventiveActivityRepository;
        }

        public async Task<StatisticsDto> Handle(GetAllStatisticsQueryRequest request, CancellationToken cancellationToken)
        {
            int numberOfEmployee = await this.employeeRepository.GetAllCountAsync();
            var avarageAgeOfEmployee = await this.employeeRepository.GetAverageAsync(x=>x.Age !=null,x=> x.Age);
            var averageDayOfWork = await this.employeeRepository.GetAverageAsync(x=>x.StartDateOfEmployment!=null,x=>EF.Functions.DateDiffDay(x.StartDateOfEmployment,DateTime.Now));
            var totalLostDays = await this.accidentRepository.GetSumAsync();
            int numberOfChronicDisease = await this.employeeChronicDiseaseRepository.GetAllCountAsync();
            int numberOfOccupationDisease = await this.employeeOccupationDiseaseRepository.GetAllCountAsync();
            int numberOfAccident = await this.accidentRepository.GetAllCountAsync();
            var lastAccident = await this.accidentRepository.GetByFilterAsync(x => x.Date!);

            int numberOfNearMisses = await this.nearMissRepository.GetAllCountAsync();
            int numberOfRiskAssessments = await this.riskAssessmentRepository.GetAllCountAsync();
            int numberOfInconsistencies = await this.inconsistencyRepository.GetAllCountAsync();
            int numberOfContingencyPlans = await this.contingencyPlanRepository.GetAllCountAsync();
            int numberOfPreventiveActivities = await this.preventiveActivityRepository.GetAllCountAsync();

            return new StatisticsDto
            {
                NumberOfEmployee = numberOfEmployee,
                AverageAgeOfEmployee = avarageAgeOfEmployee,
                AverageDayOfWork = averageDayOfWork,
                NumberOfChronicDisease = numberOfChronicDisease,
                NumberOfOccupationDisease = numberOfOccupationDisease,
                NumberOfAccidents = numberOfAccident,
                NumberOfNearMisses = numberOfNearMisses,
                DayOfLastAccident = lastAccident?.Date,
                NumberOfRiskAssessments = numberOfRiskAssessments,
                NumberOfInconsistencies = numberOfInconsistencies,
                NumberOfContingencyPlans = numberOfContingencyPlans,
                NumberOfPreventiveActivities = numberOfPreventiveActivities



            };



        }
    }
}
