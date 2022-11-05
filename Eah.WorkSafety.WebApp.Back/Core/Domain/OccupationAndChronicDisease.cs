namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class OccupationAndChronicDisease
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Diagnosis { get; set; }

        public int PersonId { get; set; }

        public DateTime DiagnosisDate { get; set; }

        public List<PersonOccupationAndChronicDisease> PersonOccupationAndChronicDiseases { get; set; }

        public int OccupationAndChronicDiseaseTypeId { get; set; }

        public OccupationAndChronicDiseaseTypes OccupationAndChronicDiseaseType { get; set; }

        public OccupationAndChronicDisease()
        {
            PersonOccupationAndChronicDiseases = new List<PersonOccupationAndChronicDisease>();
            OccupationAndChronicDiseaseType = new OccupationAndChronicDiseaseTypes();
        }
    }
}
