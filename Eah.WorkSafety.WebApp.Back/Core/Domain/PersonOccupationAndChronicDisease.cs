namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class PersonOccupationAndChronicDisease
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int OccupationAndChronicDiseaseId { get; set; }

        public OccupationAndChronicDisease OccupationAndChronicDisease { get; set; }

        public PersonOccupationAndChronicDisease()
        {
            OccupationAndChronicDisease = new OccupationAndChronicDisease();
            Person = new Person();
        }
    }
}
