using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateAccidentCommandHandler : IRequestHandler<UpdateAccidentCommandRequest>
    {
        private readonly IRepository<Accident> repository;

        public UpdateAccidentCommandHandler(IRepository<Accident> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateAccidentCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIdAsync(x=>x.Id == request.Id, x=>x.Employees);
            if (updatedEntity != null)
            {
                updatedEntity.ReferenceNumber = request.ReferenceNumber;
                updatedEntity.AccidentInfo = request.AccidentInfo;
                updatedEntity.PerformedJob = request.PerformedJob;
                updatedEntity.RelatedDepartment = request.RelatedDepartment;
                updatedEntity.NeedFirstAid = request.NeedFirstAid;
                updatedEntity.MedicalIntervention = request.MedicalIntervention;
                updatedEntity.Eyewitnesses = request.Eyewitnesses;
                updatedEntity.EyewitnessesName = request.EyewitnessesName;
                updatedEntity.EyewitnessesPhoneNumber = request.EyewitnessesPhoneNumber;
                updatedEntity.WitnessStatement = request.WitnessStatement;
                updatedEntity.DuringOperation = request.DuringOperation;
                updatedEntity.PropertyDamage = request.PropertyDamage;
                updatedEntity.BusinessStopped = request.BusinessStopped;
                updatedEntity.CameraRecording = request.CameraRecording;
                updatedEntity.Date = request.Date;
                updatedEntity.RootCauseAnalysis = request.RootCauseAnalysis;
                updatedEntity.CreatorUserId = request.CreatorUserId;
                var employees = new List<EmployeeAccident>();
                if (request.AffectedEmployeeIdWithLostDaysList != null)
                {
                    foreach (var item in request.AffectedEmployeeIdWithLostDaysList)
                    {
                        employees.Add(new EmployeeAccident() { EmployeeId=item.Key,LostDays=item.Value});
                    }
                }
                updatedEntity.Employees = employees;
                await this.repository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;

        }
    }
}
