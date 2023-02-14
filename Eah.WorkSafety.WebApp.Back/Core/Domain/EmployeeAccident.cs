namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class EmployeeAccident
    {
        public int EmployeeId { get; set; }

        public int AccidentId { get; set; }

        public int LostDays { get; set; }

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
        public Employee? Employee { get; set; }

        public Accident? Accident { get; set; }

        public EmployeeAccident()
        {
        }
    }
}
