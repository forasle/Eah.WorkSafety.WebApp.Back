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
                        ThePrecautionsToBeTakenOfEmployeeAccident = new Domain.ThePrecautionsToBeTakenOfEmployeeAccident
                        {
                            WorkingWithoutAuthorization = item.ThePrecautionsToBeTakenOfEmployeeAccident!.WorkingWithoutAuthorization,
                            GiveOrReceiveFalseWarnings = item.ThePrecautionsToBeTakenOfEmployeeAccident!.GiveOrReceiveFalseWarnings,
                            ErrorInSafety = item.ThePrecautionsToBeTakenOfEmployeeAccident!.ErrorInSafety,
                            ImproperSpeed = item.ThePrecautionsToBeTakenOfEmployeeAccident!.ImproperSpeed,
                            NotUsingEquipmentProtectors = item.ThePrecautionsToBeTakenOfEmployeeAccident!.NotUsingEquipmentProtectors,
                            NotUsingPersonalProtectiveEquipment = item.ThePrecautionsToBeTakenOfEmployeeAccident!.NotUsingPersonalProtectiveEquipment,
                            EquipmentUsageError = item.ThePrecautionsToBeTakenOfEmployeeAccident!.EquipmentUsageError,
                            UsingFaultyEquipment = item.ThePrecautionsToBeTakenOfEmployeeAccident!.UsingFaultyEquipment,
                            WorkingInAnUnfamiliarField = item.ThePrecautionsToBeTakenOfEmployeeAccident!.WorkingInAnUnfamiliarField,
                            DisobeyingInstructions = item.ThePrecautionsToBeTakenOfEmployeeAccident!.DisobeyingInstructions,
                            TirednessOrInsomniaOrDrowsiness = item.ThePrecautionsToBeTakenOfEmployeeAccident!.TirednessOrInsomniaOrDrowsiness,
                            WorkingWithoutDiscipline = item.ThePrecautionsToBeTakenOfEmployeeAccident!.WorkingWithoutDiscipline,
                            InsufficientMachineEquipmentEnclosure = item.ThePrecautionsToBeTakenOfEmployeeAccident!.InsufficientMachineEquipmentEnclosure,
                        },
                       TheSubjectOfTheAccidentOfEmployeeAccident = new Domain.TheSubjectOfTheAccidentOfEmployeeAccident
                       {
                           ExposureToPhsicalViolence = item.TheSubjectOfTheAccidentOfEmployeeAccident!.ExposureToPhsicalViolence,
                           ExposureToVerbalViolence = item.TheSubjectOfTheAccidentOfEmployeeAccident!.ExposureToVerbalViolence,
                           SharpObjectInjuries = item.TheSubjectOfTheAccidentOfEmployeeAccident!.SharpObjectInjuries,
                           ExposureToBiologicalAgents = item.TheSubjectOfTheAccidentOfEmployeeAccident!.ExposureToBiologicalAgents,
                           FallingImpactInjuries = item.TheSubjectOfTheAccidentOfEmployeeAccident!.FallingImpactInjuries,
                           MaterialDamagedTrafficAccident = item.TheSubjectOfTheAccidentOfEmployeeAccident!.MaterialDamagedTrafficAccident,
                           InjuredTrafficAccident = item.TheSubjectOfTheAccidentOfEmployeeAccident!.InjuredTrafficAccident,
                           ExposureToChemicals = item.TheSubjectOfTheAccidentOfEmployeeAccident!.ExposureToChemicals,
                           ExposureToFireAndBurn = item.TheSubjectOfTheAccidentOfEmployeeAccident!.ExposureToFireAndBurn,
                           OfficeAccidents = item.TheSubjectOfTheAccidentOfEmployeeAccident!.OfficeAccidents,
                           ElectricalAccidents = item.TheSubjectOfTheAccidentOfEmployeeAccident!.ElectricalAccidents
                       }
                    }) ;

                }
            }

            await this.repository.CreateAsync(accident);

            //await this.thePrecautionsToBeTakenOfEmployeeAccidentReporsitory.CreateAsync(thePrecautionToBeTaken);


            return Unit.Value;
        }
    }
}
