using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Enums;
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
        private readonly IRepository<User> userRepository;
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
        private readonly IRepository<Mission> missionRepository;


        public GetAllStatisticsQueryHandler(IRepository<Employee> employeeRepository, IRepository<EmployeeChronicDisease> employeeChronicDiseaseRepository, IRepository<EmployeeOccupationDisease> employeeOccupationDiseaseRepository, IRepository<EmployeeAccident> employeeAccidentRepository, IRepository<EmployeeNearMiss> employeeNearMissRepository, IRepository<Accident> accidentRepository, IRepository<NearMiss> nearMissRepository, IRepository<RiskAssessment> riskAssessmentRepository, IRepository<Inconsistency> inconsistencyRepository, IRepository<ContingencyPlan> contingencyPlanRepository, IRepository<PreventiveActivity> preventiveActivityRepository, IRepository<Mission> missionRepository, IRepository<User> userRepository)
        {
            this.employeeRepository = employeeRepository;
            this.userRepository = userRepository;
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
            this.missionRepository = missionRepository;
        }

        public async Task<StatisticsDto> Handle(GetAllStatisticsQueryRequest request, CancellationToken cancellationToken)
        {
            int numberOfEmployee = await this.employeeRepository.GetAllCountAsync();
            int numberOfUser = await this.userRepository.GetAllCountAsync();
            var avarageAgeOfEmployee = await this.employeeRepository.GetAverageAsync(x => x.Age != null, x => x.Age);
            var averageDayOfWork = await this.employeeRepository.GetAverageAsync(x => x.StartDateOfEmployment != null, x => EF.Functions.DateDiffDay(x.StartDateOfEmployment, DateTime.Now));
            var totalLostDays = await this.employeeAccidentRepository.GetSumAsync(x => x.LostDays) + await this.employeeNearMissRepository.GetSumAsync(x => x.LostDays);
            var totalEmployeeAccident = await this.employeeAccidentRepository.GetAllCountAsync();
            var totalLostDaysAccident = await this.employeeAccidentRepository.GetAllCountAsync(x => x.LostDays > 0);
            var totalNeedFirstAidAccident = await this.accidentRepository.GetAllCountAsync(x => x.NeedFirstAid == true);
            var totalNeedFirstAidButNoLostDaysAccident = await this.accidentRepository.GetCountByJoin();
            int numberOfChronicDisease = await this.employeeChronicDiseaseRepository.GetAllCountAsync();
            int numberOfOccupationDisease = await this.employeeOccupationDiseaseRepository.GetAllCountAsync();
            int numberOfAccident = await this.accidentRepository.GetAllCountAsync();
            var lastAccident = await this.accidentRepository.GetByFilterAsync(x => x.Date!);

            int numberOfNearMisses = await this.nearMissRepository.GetAllCountAsync();
            int numberOfRiskAssessments = await this.riskAssessmentRepository.GetAllCountAsync();
            int numberOfInconsistencies = await this.inconsistencyRepository.GetAllCountAsync();
            int numberOfContingencyPlans = await this.contingencyPlanRepository.GetAllCountAsync();
            int numberOfPreventiveActivities = await this.preventiveActivityRepository.GetAllCountAsync();
            int numberOfMissions = await this.missionRepository.GetAllCountAsync();

            int numberOfEmployeeBelow16 = await this.employeeRepository.GetAllCountAsync(x => x.Age < 17);
            int numberOfEmployeeBetween16_18 = await this.employeeRepository.GetAllCountAsync(x => (x.Age > 16) && (x.Age < 19));
            int numberOfEmployeeBetween19_25 = await this.employeeRepository.GetAllCountAsync(x => (x.Age > 18) && (x.Age < 26));
            int numberOfEmployeeBetween26_45 = await this.employeeRepository.GetAllCountAsync(x => (x.Age > 25) && (x.Age < 46));
            int numberOfEmployeeBetween46_60 = await this.employeeRepository.GetAllCountAsync(x => (x.Age > 45) && (x.Age < 61));
            int numberOfEmployeeAbove60 = await this.employeeRepository.GetAllCountAsync(x => (x.Age > 60));

            int numberOfEmployeeByDepartment = await this.employeeRepository.GetAllCountAsync(x => x.Department == Department.Acil);

            int numberOfMaleEmployee = await this.employeeRepository.GetAllCountAsync(x => x.Gender == Gender.Male);
            int numberOfFemaleEmployee = await this.employeeRepository.GetAllCountAsync(x => x.Gender == Gender.Female);
            int numberOfUnspecifiedEmployee = await this.employeeRepository.GetAllCountAsync(x=>x.Gender == Gender.Unspecified);


            return new StatisticsDto
            {
                NumberOfEmployee = numberOfEmployee,
                NumberOfUser = numberOfUser,
                AverageAgeOfEmployee = avarageAgeOfEmployee,
                AverageDayOfWork = averageDayOfWork,
                TotalEmployeeAccident = totalEmployeeAccident,
                TotalLostDaysAccident = totalLostDaysAccident,
                TotalLostDays = totalLostDays,
                TotalNeedFirstAidAccident=totalNeedFirstAidAccident,
                TotalNeedFirstAidButNoLostDaysAccident=totalNeedFirstAidButNoLostDaysAccident,
                NumberOfChronicDisease = numberOfChronicDisease,
                NumberOfOccupationDisease = numberOfOccupationDisease,
                NumberOfAccidents = numberOfAccident,
                NumberOfNearMisses = numberOfNearMisses,
                DayOfLastAccident = lastAccident?.Date,
                NumberOfRiskAssessments = numberOfRiskAssessments,
                NumberOfInconsistencies = numberOfInconsistencies,
                NumberOfContingencyPlans = numberOfContingencyPlans,
                NumberOfPreventiveActivities = numberOfPreventiveActivities,
                NumberOfMissions = numberOfMissions
            };



        }
    }
}
