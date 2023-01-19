namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class TheSubjectOfTheAccidentOfEmployeeAccident
    {
        public int id { get; set; }
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
        public EmployeeAccident? EmployeAccident { get; set; }
    }
}
