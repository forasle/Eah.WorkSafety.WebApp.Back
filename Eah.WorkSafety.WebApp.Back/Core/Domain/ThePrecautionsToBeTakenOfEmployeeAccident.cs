namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class ThePrecautionsToBeTakenOfEmployeeAccident
    {
        public int id { get; set; }
        public int EmployeeAccidentId { get; set; }
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
        public EmployeeAccident? EmployeAccident { get; set; }

    }
}
