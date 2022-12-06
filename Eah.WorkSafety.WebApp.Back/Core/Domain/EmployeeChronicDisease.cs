namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class EmployeeChronicDisease
    {
        public int EmployeeId { get; set; }

        public int ChronicDiseaseId { get; set; }
        public Employee? Employee { get; set; }

        public ChronicDisease? ChronicDisease { get; set; }

        public EmployeeChronicDisease()
        {
        }
    }
}
