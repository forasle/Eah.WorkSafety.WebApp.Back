using Eah.WorkSafety.WebApp.Back.Core.Application.Enums;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System.Reflection;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateAccidentCommandHandler : IRequestHandler<CreateAccidentCommandRequest>
    {
        private readonly IRepository<Accident> accidentRepository;
        private readonly IRepository<EmployeeAccident> employeeAccidentRepository;

        public CreateAccidentCommandHandler(IRepository<Accident> accidentRepository, IRepository<EmployeeAccident> employeeAccidentRepository)
        {
            this.accidentRepository = accidentRepository;
            this.employeeAccidentRepository = employeeAccidentRepository;
        }

        public async Task<Unit> Handle(CreateAccidentCommandRequest request, CancellationToken cancellationToken)
        {
            var thePrecautionToBeTaken = new ThePrecautionsToBeTakenOfEmployeeAccident { };
            var accident = new Accident
            {
                ReferenceNumber = request.ReferenceNumber,
                AccidentInfo = request.AccidentInfo,
                PerformedJob=request.PerformedJob,
                RelatedDepartment=request.RelatedDepartment,
                NeedFirstAid=request.NeedFirstAid,
                MedicalIntervention=request.MedicalIntervention,
                Eyewitnesses=request.Eyewitnesses,
                EyewitnessesName=request.EyewitnessesName,
                EyewitnessesPhoneNumber=request.EyewitnessesPhoneNumber,
                WitnessStatement=request.WitnessStatement,
                DuringOperation=request.DuringOperation,
                PropertyDamage=request.PropertyDamage,
                BusinessStopped=request.BusinessStopped,
                CameraRecording=request.CameraRecording,
                Date = request.Date,
                RootCauseAnalysis = request.RootCauseAnalysis,
                CreatorUserId = request.CreatorUserId,

            };
            if (request.AffectedEmployeeIdWithLostDaysList != null)
            {
                foreach (var item in request.AffectedEmployeeIdWithLostDaysList)
                {
                    accident.Employees.Add(new EmployeeAccident()
                    {
                        EmployeeId = item.Key,
                        LostDays = item.Value,

                        
                    });
                }
            }

            if (request.ThePrecautionsToBeTakenOfEmployeeAccident != null)
            {
                foreach (var item in request.ThePrecautionsToBeTakenOfEmployeeAccident)
                {
                    thePrecautionToBeTaken.WorkingWithoutAuthorization = item.Value[0];
                    thePrecautionToBeTaken.GiveOrReceiveFalseWarnings = item.Value[1];
                    thePrecautionToBeTaken.ErrorInSafety = item.Value[2];
                    thePrecautionToBeTaken.ImproperSpeed = item.Value[3];
                    thePrecautionToBeTaken.NotUsingEquipmentProtectors = item.Value[4];
                    thePrecautionToBeTaken.NotUsingPersonalProtectiveEquipment = item.Value[5];
                    thePrecautionToBeTaken.EquipmentUsageError = item.Value[6];
                    thePrecautionToBeTaken.UsingFaultyEquipment = item.Value[7];
                    thePrecautionToBeTaken.WorkingInAnUnfamiliarField = item.Value[8];
                    thePrecautionToBeTaken.DisobeyingInstructions = item.Value[9];
                    thePrecautionToBeTaken.TirednessOrInsomniaOrDrowsiness = item.Value[10];
                    thePrecautionToBeTaken.WorkingWithoutDiscipline = item.Value[11];
                    thePrecautionToBeTaken.InsufficientMachineEquipmentEnclosure = item.Value[12];
                }
            }


            await this.thePrecautionsToBeTakenOfEmployeeAccidentReporsitory.CreateAsync(thePrecautionToBeTaken);
            await this.accidentRepository.CreateAsync(accident);

            return Unit.Value;
        }
    }
}
