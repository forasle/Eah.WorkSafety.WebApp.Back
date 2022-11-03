namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class OccupationAndChronicDisease
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Diagnosis { get; set; }

        public int OwnerUserId { get; set; }

        public DateTime DiagnosisDate { get; set; }

        public List<PersonOccupationAndChronicDisease> PersonOccupationAndChronicDiseases { get; set; }

        public OccupationAndChronicDisease()
        {
            PersonOccupationAndChronicDiseases = new List<PersonOccupationAndChronicDisease>();
        }
    }
}
