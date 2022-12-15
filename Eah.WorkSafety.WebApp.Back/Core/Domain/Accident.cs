using System.Reflection.Metadata.Ecma335;

namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class Accident
    {
        public int Id { get; set; }

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

        public User? User { get; set; }

        public List<EmployeeAccident> Employees { get; set; }

        public Accident()
        {
            Employees = new List<EmployeeAccident>();
        }


    }
}
