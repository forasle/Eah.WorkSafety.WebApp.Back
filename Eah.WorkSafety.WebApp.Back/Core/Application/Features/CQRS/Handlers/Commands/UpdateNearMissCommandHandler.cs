using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateNearMissCommandHandler : IRequestHandler<UpdateNearmissCommandRequest>
    {
        private readonly IRepository<NearMiss> repository;

        public UpdateNearMissCommandHandler(IRepository<NearMiss> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateNearmissCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIdAsync(request.Id);
            
            if (updatedEntity != null)
            {
                updatedEntity!.Employees.Clear();
                updatedEntity.NearMissNumber = request.NearMissNumber;
                updatedEntity.ReferenceNumber = request.ReferenceNumber;
                updatedEntity.NearMissInfo = request.NearMissInfo;
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
                var employees = new List<EmployeeNearMiss>();
                if (request.UpdateAffectedEmployeeWithPropertyForNearMiss != null)
                {
                    foreach (var item in request.UpdateAffectedEmployeeWithPropertyForNearMiss)
                    {
                        employees.Add(new EmployeeNearMiss() { EmployeeId = item.EmployeeId,LostDays = item.LostDays });
                    }
                }
                updatedEntity.Employees = employees;

                await this.repository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;

        }
    }
}
