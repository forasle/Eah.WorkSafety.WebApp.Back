using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateNearMissCommandRequest : IRequest
    {
        public int Id { get; set; }

        public string? SceneOfNearMiss { get; set; }

        public string? NearMissInfo { get; set; }

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

        public DateTime NearMissDate { get; set; }

        public DateTime CreationDate { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public int CreatorUserId { get; set; }

        public List<CreateAffectedEmployeeWithPropertyForNearMiss>? CreateAffectedEmployeeWithPropertyForNearMiss { get; set; }

    }
    public class CreateAffectedEmployeeWithPropertyForNearMiss
    {
        public int EmployeeId { get; set; }
        public int LostDays { get; set; }

        public bool? TheSubjectExposureToPhysicalViolence { get; set; }
        public bool? TheSubjectExposureToVerbalViolence { get; set; }
        public bool? TheSubjectSharpObjectInjuries { get; set; }
        public bool? TheSubjectExposureToBiologicalAgents { get; set; }
        public bool? TheSubjectFallingImpactInjuries { get; set; }
        public bool? TheSubjectMaterialDamagedTrafficAccident { get; set; }
        public bool? TheSubjectInjuredTrafficAccident { get; set; }
        public bool? TheSubjectExposureToChemicals { get; set; }
        public bool? TheSubjectExposureToFireAndBurn { get; set; }
        public bool? TheSubjectOfficeAccidents { get; set; }
        public bool? TheSubjectElectricalAccidents { get; set; }

        public bool? ThePrecautionsWorkingWithoutAuthorization { get; set; }
        public bool? ThePrecautionsGiveOrReceiveFalseWarnings { get; set; }
        public bool? ThePrecautionsErrorInSafety { get; set; }
        public bool? ThePrecautionsImproperSpeed { get; set; }
        public bool? ThePrecautionsNotUsingEquipmentProtectors { get; set; }
        public bool? ThePrecautionsNotUsingPersonalProtectiveEquipment { get; set; }
        public bool? ThePrecautionsEquipmentUsageError { get; set; }
        public bool? ThePrecautionsUsingFaultyEquipment { get; set; }
        public bool? ThePrecautionsWorkingInAnUnfamiliarField { get; set; }
        public bool? ThePrecautionsDisobeyingInstructions { get; set; }
        public bool? ThePrecautionsTirednessOrInsomniaOrDrowsiness { get; set; }
        public bool? ThePrecautionsWorkingWithoutDiscipline { get; set; }
        public bool? ThePrecautionsInsufficientMachineEquipmentEnclosure { get; set; }

    }
}