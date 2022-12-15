namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class NearMissDto
    {
        public int Id { get; set; }

        public int NearMissNumber { get; set; }

        public string? ReferenceNumber { get; set; }

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

        public DateTime? Date { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public int CreatorUserId { get; set; }

        public Dictionary<int, int>? AffectedEmployeeIdWithLostDaysList { get; set; }

    }
}
