using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using Microsoft.VisualBasic;
using System.Reflection;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateAccidentCommandHandler : IRequestHandler<CreateAccidentCommandRequest>
    {
        private readonly IRepository<Accident> repository;

        public CreateAccidentCommandHandler(IRepository<Accident> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateAccidentCommandRequest request, CancellationToken cancellationToken)
        {

            var accident = new Accident
            {
                ReferenceNumber = request.ReferenceNumber,
                AccidentInfo = request.AccidentInfo,
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
                Date = request.Date,
                RootCauseAnalysis = request.RootCauseAnalysis,
                CreatorUserId = request.CreatorUserId,

            };

            if (request.CreateAffectedEmployeeWithProperty != null)
            {
                foreach(var item in request.CreateAffectedEmployeeWithProperty)
                {
                    accident.Employees.Add(new EmployeeAccident()
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


                    }) ;

                }
            }

            await this.repository.CreateAsync(accident);

            //await this.thePrecautionsToBeTakenOfEmployeeAccidentReporsitory.CreateAsync(thePrecautionToBeTaken);


            return Unit.Value;
        }
    }
}
