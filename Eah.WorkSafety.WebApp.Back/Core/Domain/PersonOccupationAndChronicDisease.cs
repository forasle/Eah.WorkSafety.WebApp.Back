namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class PersonOccupationAndChronicDisease
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person? Person { get; set; }

        public int OccupationAndChronicDiseaseId { get; set; }

        public DateTime? DiagnosisDate { get; set; }

        public OccupationAndChronicDisease? OccupationAndChronicDisease { get; set; }

        public PersonOccupationAndChronicDisease()
        {
        }
    }
}
