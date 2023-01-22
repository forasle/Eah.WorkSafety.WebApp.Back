using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateAccidentCommandRequest : IRequest
    {
        public int Id { get; set; }

        public int AccidentNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? AccidentInfo { get; set; }
        public string? PerformedJob { get; set; }

        public string? RelatedDepartment { get; set; }

        public bool? NeedFirstAid { get; set; }

        public bool? MedicalIntervention { get; set; }

        public bool? Eyewitnesses { get; set; }

        public string? EyewitnessesName { get; set; }

        public string? EyewitnessesPhoneNumber { get; set; }

        public string? WitnessStatement { get; set; }

        public bool? DuringOperation { get; set; }

        public bool? PropertyDamage { get; set; }

        public bool? BusinessStopped { get; set; }

        public bool? CameraRecording { get; set; }

        public DateTime? Date { get; set; }

        public bool RootCauseAnalysis { get; set; }


        public int CreatorUserId { get; set; }

        public List<CreateAffectedEmployeeWithProperty>? CreateAffectedEmployeeWithProperty { get; set; }

    }
    public class CreateAffectedEmployeeWithProperty
    {
        public int EmployeeId { get; set; }
        public int LostDays { get; set; }

        public ThePrecautionsToBeTakenOfEmployeeAccident? ThePrecautionsToBeTakenOfEmployeeAccident { get; set; }

        public TheSubjectOfTheAccidentOfEmployeeAccident? TheSubjectOfTheAccidentOfEmployeeAccident { get; set; }
    }

    public class ThePrecautionsToBeTakenOfEmployeeAccident
    {
        public bool? WorkingWithoutAuthorization { get; set; }
        public bool? GiveOrReceiveFalseWarnings { get; set; }
        public bool? ErrorInSafety { get; set; }
        public bool? ImproperSpeed { get; set; }
        public bool? NotUsingEquipmentProtectors { get; set; }
        public bool? NotUsingPersonalProtectiveEquipment { get; set; }
        public bool? EquipmentUsageError { get; set; }
        public bool? UsingFaultyEquipment { get; set; }
        public bool? WorkingInAnUnfamiliarField { get; set; }
        public bool? DisobeyingInstructions { get; set; }
        public bool? TirednessOrInsomniaOrDrowsiness { get; set; }
        public bool? WorkingWithoutDiscipline { get; set; }
        public bool? InsufficientMachineEquipmentEnclosure { get; set; }
    }
    public class TheSubjectOfTheAccidentOfEmployeeAccident
    {
        public bool? ExposureToPhsicalViolence { get; set; }
        public bool? ExposureToVerbalViolence { get; set; }
        public bool? SharpObjectInjuries { get; set; }
        public bool? ExposureToBiologicalAgents { get; set; }
        public bool? FallingImpactInjuries { get; set; }
        public bool? MaterialDamagedTrafficAccident { get; set; }
        public bool? InjuredTrafficAccident { get; set; }
        public bool? ExposureToChemicals { get; set; }
        public bool? ExposureToFireAndBurn { get; set; }
        public bool? OfficeAccidents { get; set; }
        public bool? ElectricalAccidents { get; set; }
    }
}
