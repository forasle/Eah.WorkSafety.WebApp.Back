using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateNearMissCommandHandler : IRequestHandler<UpdateNearMissCommandRequest>
    {
        private readonly IRepository<NearMiss> nearMissRepository;
        private readonly IRepository<EmployeeNearMiss> employeeNearMissRepository;

        public UpdateNearMissCommandHandler(IRepository<NearMiss> nearMissRepository, IRepository<EmployeeNearMiss> employeeNearMissRepository)
        {
            this.nearMissRepository = nearMissRepository;
            this.employeeNearMissRepository = employeeNearMissRepository;
        }

        public async Task<Unit> Handle(UpdateNearMissCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.nearMissRepository.GetByIdAsync(x => x.Id == request.Id, x => x.Employees);
            if (updatedEntity != null)
            {
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

                for (int i = updatedEntity.Employees.Count(); i > 0; i--)
                {
                    await this.employeeNearMissRepository.DeleteAsync(updatedEntity.Employees[i - 1]);
                }

                if (request.UpdateAffectedEmployeeWithPropertyForNearMiss != null)
                {
                    foreach (var item in request.UpdateAffectedEmployeeWithPropertyForNearMiss)
                    {
                        updatedEntity.Employees.Add(new EmployeeNearMiss()
                        {

                            EmployeeId = item.EmployeeId,
                            LostDays = item.LostDays,
                            TheSubjectExposureToFireAndBurn = item.TheSubjectExposureToFireAndBurn,
                            TheSubjectExposureToChemicals = item.TheSubjectExposureToChemicals,
                            TheSubjectSharpObjectInjuries = item.TheSubjectSharpObjectInjuries,
                            TheSubjectOfficeAccidents = item.TheSubjectOfficeAccidents,
                            TheSubjectMaterialDamagedTrafficAccident = item.TheSubjectMaterialDamagedTrafficAccident,
                            TheSubjectInjuredTrafficAccident = item.TheSubjectInjuredTrafficAccident,
                            TheSubjectFallingImpactInjuries = item.TheSubjectFallingImpactInjuries,
                            TheSubjectElectricalAccidents = item.TheSubjectElectricalAccidents,
                            TheSubjectExposureToBiologicalAgents = item.TheSubjectExposureToBiologicalAgents,
                            TheSubjectExposureToPhysicalViolence = item.TheSubjectExposureToPhysicalViolence,
                            TheSubjectExposureToVerbalViolence = item.TheSubjectExposureToVerbalViolence,

                            ThePrecautionsErrorInSafety = item.ThePrecautionsErrorInSafety,
                            ThePrecautionsDisobeyingInstructions = item.ThePrecautionsDisobeyingInstructions,
                            ThePrecautionsEquipmentUsageError = item.ThePrecautionsEquipmentUsageError,
                            ThePrecautionsGiveOrReceiveFalseWarnings = item.ThePrecautionsGiveOrReceiveFalseWarnings,
                            ThePrecautionsImproperSpeed = item.ThePrecautionsImproperSpeed,
                            ThePrecautionsInsufficientMachineEquipmentEnclosure = item.ThePrecautionsInsufficientMachineEquipmentEnclosure,
                            ThePrecautionsNotUsingEquipmentProtectors = item.ThePrecautionsNotUsingEquipmentProtectors,
                            ThePrecautionsNotUsingPersonalProtectiveEquipment = item.ThePrecautionsNotUsingPersonalProtectiveEquipment,
                            ThePrecautionsTirednessOrInsomniaOrDrowsiness = item.ThePrecautionsTirednessOrInsomniaOrDrowsiness,
                            ThePrecautionsUsingFaultyEquipment = item.ThePrecautionsUsingFaultyEquipment,
                            ThePrecautionsWorkingInAnUnfamiliarField = item.ThePrecautionsWorkingInAnUnfamiliarField,
                            ThePrecautionsWorkingWithoutAuthorization = item.ThePrecautionsWorkingWithoutAuthorization,
                            ThePrecautionsWorkingWithoutDiscipline = item.ThePrecautionsWorkingWithoutDiscipline

                        });

                    }
                }
                await this.nearMissRepository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;

        }
    }
}