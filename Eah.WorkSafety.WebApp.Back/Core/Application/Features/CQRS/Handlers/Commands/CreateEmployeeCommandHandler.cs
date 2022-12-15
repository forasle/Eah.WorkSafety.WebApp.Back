using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommandRequest>
    {
        private readonly IRepository<Employee> repository;

        public CreateEmployeeCommandHandler(IRepository<Employee> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
            var employee = new Employee
            {
                IdentificationNumber = request.IdentificationNumber,
                RegistrationNumber = request.RegistrationNumber,
                Name = request.Name,
                Surname = request.Surname,
                Age = request.Age,
                BirthPlace= request.BirthPlace,
                Nationality= request.Nationality,
                EducationStatus= request.EducationStatus,
                RiskGroup= request.RiskGroup,
                Title= request.Title,
                Position = request.Position,
                Department = request.Department,
                StartDateOfEmployment = request.StartDateOfEmployment,
                Address = request.Address
                
            };
            var accidents = new List<EmployeeAccident>();
            if (request.Accidents != null)
            {
                foreach (var item in request.Accidents)
                {
                    accidents.Add(new EmployeeAccident()
                    {
                        AccidentId = item.Key,
                        LostDays=item.Value
                    });

                }
                employee.Accidents = accidents;
            }
            
            var nearMisses = new List<EmployeeNearMiss>();
            if (request.NearMisses != null)
            {
                foreach (var item in request.NearMisses)
                {
                    nearMisses.Add(new EmployeeNearMiss()
                    {
                        NearMissId = item.Key,
                        LostDays = item.Value
                    });

                }
                employee.NearMisses = nearMisses;
            }

            var chronicDisease = new List<EmployeeChronicDisease>();
            if (request.ChronicDiseases != null)
            {
                foreach (var item in request.ChronicDiseases)
                {
                    chronicDisease.Add(new EmployeeChronicDisease()
                    {
                        ChronicDiseaseId = item
                    });

                }
                employee.ChronicDiseases = chronicDisease;
            }

            var occupationDisease = new List<EmployeeOccupationDisease>();
            if (request.OccupationDiseases != null)
            {
                foreach (var item in request.OccupationDiseases)
                {
                    occupationDisease.Add(new EmployeeOccupationDisease()
                    {
                        OccupationDiseaseId = item
                    });

                }
                employee.OccupationDiseases = occupationDisease;
            }

            await this.repository.CreateAsync(employee);
            return Unit.Value;
        }
    }
}
