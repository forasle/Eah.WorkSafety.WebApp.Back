using Eah.WorkSafety.WebApp.Back.Core.Application.Enums;
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
        private readonly IRepository<Accident> accidentRepository;
        private readonly IRepository<EmployeeAccident> employeeAccidentRepository;

        public CreateAccidentCommandHandler(IRepository<Accident> accidentRepository, IRepository<EmployeeAccident> employeeAccidentRepository)
        {
            this.accidentRepository = accidentRepository;
            this.employeeAccidentRepository = employeeAccidentRepository;
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

            if (request.AffectedEmployeeWithProperty != null)
            {
                foreach(List<dynamic> item in request.AffectedEmployeeWithProperty)
                {

                    var a = item[2]21 [0];
                    var b = item[2][0];
                    var f = item[2][0];
                    var g = item[2][0];
                    var v = item[2][0];
                    var vv = item[2][0];
                    var j = item[2][0];
                    var r = item[2][0];
                    var k = item[2][0];
                    var s = item[2][0];
                    var z = item[2][0];
                    var zz = item[2][0];
                    var zzz = item[2][0];
                    var vvv = item[2][0];
                    var jjj = item[2][0];


                    List<bool> theS = item[3];
                    
                    var thePrecautionToBeTaken = new ThePrecautionsToBeTakenOfEmployeeAccident {
                        WorkingWithoutAuthorization = theP[0],
                        GiveOrReceiveFalseWarnings = theP[1],
                        ErrorInSafety = theP[2],
                        ImproperSpeed = theP[3],
                        NotUsingEquipmentProtectors = theP[4],
                        NotUsingPersonalProtectiveEquipment = theP[5],
                        EquipmentUsageError = theP[6],
                        UsingFaultyEquipment = theP[7],
                        WorkingInAnUnfamiliarField = theP[8],
                        DisobeyingInstructions = theP[9],
                        TirednessOrInsomniaOrDrowsiness = theP[10],
                        WorkingWithoutDiscipline = theP[11],
                        InsufficientMachineEquipmentEnclosure = theP[12],
                    };

                    var theSubjectOfTheAccident = new TheSubjectOfTheAccidentOfEmployeeAccident {
                        ExposureToPhsicalViolence = item[3][0],
                        ExposureToVerbalViolence = item[3][1],
                        SharpObjectInjuries = item[3][2],
                        ExposureToBiologicalAgents = item[3][3],
                        FallingImpactInjuries = item[3][4],
                        MaterialDamagedTrafficAccident = item[3][5],
                        InjuredTrafficAccident = item[3][6],
                        ExposureToChemicals = item[3][7],
                        ExposureToFireAndBurn = item[3][8],
                        OfficeAccidents = item[3][9],
                        ElectricalAccidents = item[3][10],
                };


                    accident.Employees.Add(new EmployeeAccident()
                    {
                        EmployeeId = request.AffectedEmployeeWithProperty[0],
                        LostDays = request.AffectedEmployeeWithProperty[1],
                        ThePrecautionsToBeTakenOfEmployeeAccident = thePrecautionToBeTaken,
                        TheSubjectOfTheAccidentOfEmployeeAccident = theSubjectOfTheAccident,
                    });
                }
                /*
                for (int i = 0; i < request.AffectedEmployeeWithProperty.Count; i++)
                {
                    thePrecautionToBeTaken.WorkingWithoutAuthorization = request.AffectedEmployeeWithProperty[i][2][0];
                    thePrecautionToBeTaken.GiveOrReceiveFalseWarnings = request.AffectedEmployeeWithProperty[i][2][1];
                    thePrecautionToBeTaken.ErrorInSafety = request.AffectedEmployeeWithProperty[i][2][2];
                    thePrecautionToBeTaken.ImproperSpeed = request.AffectedEmployeeWithProperty[i][2][3];
                    thePrecautionToBeTaken.NotUsingEquipmentProtectors = request.AffectedEmployeeWithProperty[i][2][4];
                    thePrecautionToBeTaken.NotUsingPersonalProtectiveEquipment = request.AffectedEmployeeWithProperty[i][2][5];
                    thePrecautionToBeTaken.EquipmentUsageError = request.AffectedEmployeeWithProperty[i][2][6];
                    thePrecautionToBeTaken.UsingFaultyEquipment = request.AffectedEmployeeWithProperty[i][2][7];
                    thePrecautionToBeTaken.WorkingInAnUnfamiliarField = request.AffectedEmployeeWithProperty[i][2][8];
                    thePrecautionToBeTaken.DisobeyingInstructions = request.AffectedEmployeeWithProperty[i][2][9];
                    thePrecautionToBeTaken.TirednessOrInsomniaOrDrowsiness = request.AffectedEmployeeWithProperty[i][2][10];
                    thePrecautionToBeTaken.WorkingWithoutDiscipline = request.AffectedEmployeeWithProperty[i][2][11];
                    thePrecautionToBeTaken.InsufficientMachineEquipmentEnclosure = request.AffectedEmployeeWithProperty[i][2][12];

                    theSubjectOfTheAccident.ExposureToPhsicalViolence = request.AffectedEmployeeWithProperty[i][3][0];
                    theSubjectOfTheAccident.ExposureToVerbalViolence = request.AffectedEmployeeWithProperty[i][3][1];
                    theSubjectOfTheAccident.SharpObjectInjuries = request.AffectedEmployeeWithProperty[i][3][2];
                    theSubjectOfTheAccident.ExposureToBiologicalAgents = request.AffectedEmployeeWithProperty[i][3][3];
                    theSubjectOfTheAccident.FallingImpactInjuries = request.AffectedEmployeeWithProperty[i][3][4];
                    theSubjectOfTheAccident.MaterialDamagedTrafficAccident = request.AffectedEmployeeWithProperty[i][3][5];
                    theSubjectOfTheAccident.InjuredTrafficAccident = request.AffectedEmployeeWithProperty[i][3][6];
                    theSubjectOfTheAccident.ExposureToChemicals = request.AffectedEmployeeWithProperty[i][3][7];
                    theSubjectOfTheAccident.ExposureToFireAndBurn = request.AffectedEmployeeWithProperty[i][3][8];
                    theSubjectOfTheAccident.OfficeAccidents = request.AffectedEmployeeWithProperty[i][3][9];
                    theSubjectOfTheAccident.ElectricalAccidents = request.AffectedEmployeeWithProperty[i][3][10];

                    accident.Employees.Add(new EmployeeAccident()
                    {
                        EmployeeId = request.AffectedEmployeeWithProperty[i][0],
                        LostDays = request.AffectedEmployeeWithProperty[i][1],
                        ThePrecautionsToBeTakenOfEmployeeAccident = thePrecautionToBeTaken,
                        TheSubjectOfTheAccidentOfEmployeeAccident = theSubjectOfTheAccident,
                    });
                  
                }*/
            }

            await this.accidentRepository.CreateAsync(accident);

            //await this.thePrecautionsToBeTakenOfEmployeeAccidentReporsitory.CreateAsync(thePrecautionToBeTaken);


            return Unit.Value;
        }
    }
}
