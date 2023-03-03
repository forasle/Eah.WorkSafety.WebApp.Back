using Eah.WorkSafety.WebApp.Back.Core.Application.Enums;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System.Reflection;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateNearMissCommandHandler : IRequestHandler<CreateNearMissCommandRequest>
    {
        private readonly IRepository<NearMiss> repository;

        public CreateNearMissCommandHandler(IRepository<NearMiss> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateNearMissCommandRequest request, CancellationToken cancellationToken)
        {
            var nearMiss = new NearMiss
            {
                NearMissNumber = request.NearMissNumber,
                SceneOfNearMiss = request.SceneOfNearMiss,
                NearMissInfo = request.NearMissInfo,
                PerformedJob = request.PerformedJob,
                RelatedDepartment = request.RelatedDepartment,
                NeedFirstAid = request.NeedFirstAid,
                MedicalIntervention = request.MedicalIntervention,
                Eyewitnesses = request.Eyewitnesses,
                EyewitnessesName = request.EyewitnessesName,
                EyewitnessesPhoneNumber = request.EyewitnessesPhoneNumber,
                WitnessStatement = request.WitnessStatement,
                DuringOperation = request.DuringOperation,
                PropertyDamage = request.PropertyDamage,
                BusinessStopped = request.BusinessStopped,
                CameraRecording = request.CameraRecording,
                NearMissDate = request.NearMissDate,
                CreationDate = request.CreationDate,
                RootCauseAnalysis = request.RootCauseAnalysis,
                CreatorUserId = request.CreatorUserId,
            };
            if (request.CreateAffectedEmployeeWithPropertyForNearMiss != null)
            {
                foreach (var item in request.CreateAffectedEmployeeWithPropertyForNearMiss)
                {
                    nearMiss.Employees.Add(new EmployeeNearMiss()
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

            await this.repository.CreateAsync(nearMiss);

            return Unit.Value;
        }
    }
}
