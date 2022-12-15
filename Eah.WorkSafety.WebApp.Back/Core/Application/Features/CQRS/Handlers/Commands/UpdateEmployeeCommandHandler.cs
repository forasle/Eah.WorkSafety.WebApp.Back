using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Eah.WorkSafety.WebApp.Back.Persistance.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommandRequest>
    {
        private readonly IRepository<Employee> repository;

        public UpdateEmployeeCommandHandler(IRepository<Employee> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
            Employee? updatedEntity = await this.repository.GetByIdAsync(x => x.Id == request.Id, x => x.Accidents, x => x.NearMisses, x => x.ChronicDiseases, x => x.OccupationDiseases);
            if(updatedEntity != null)
            {
                updatedEntity.IdentificationNumber = request.IdentificationNumber;
                updatedEntity.RegistrationNumber = request.RegistrationNumber;
                updatedEntity.Name = request.Name;
                updatedEntity.Surname = request.Surname;
                updatedEntity.Age = request.Age;
                updatedEntity.BirthPlace= request.BirthPlace;
                updatedEntity.Nationality= request.Nationality;
                updatedEntity.EducationStatus= request.EducationStatus;
                updatedEntity.RiskGroup= request.RiskGroup;
                updatedEntity.Title= request.Title;
                updatedEntity.Position = request.Position;
                updatedEntity.Department = request.Department;
                updatedEntity.StartDateOfEmployment = request.StartDateOfEmployment;
                updatedEntity.Address = request.Address;

                var accidents = new List<EmployeeAccident>();
                if (request.Accidents != null)
                {
                    foreach (var item in request.Accidents)
                    {
                        accidents.Add(new EmployeeAccident()
                        {
                            AccidentId = item.Key,
                            LostDays = item.Value,
                        });

                    }
                    updatedEntity.Accidents = accidents;
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
                    updatedEntity.NearMisses = nearMisses;
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
                    updatedEntity.ChronicDiseases = chronicDisease;
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
                    updatedEntity.OccupationDiseases = occupationDisease;
                }

                await this.repository.UpdateAsync(updatedEntity);
            }
           
            return Unit.Value;
        }
    }
}
