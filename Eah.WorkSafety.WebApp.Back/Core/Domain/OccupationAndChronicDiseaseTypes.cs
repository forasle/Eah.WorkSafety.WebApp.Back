namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class OccupationAndChronicDiseaseTypes
    {
        public int Id { get; set; }

        public string? Definition { get; set; }

        public List<OccupationAndChronicDisease> OccupationAndChronicDisease { get; set; }

        public OccupationAndChronicDiseaseTypes()
        {
            OccupationAndChronicDisease = new List<OccupationAndChronicDisease>();
        }
    }
}
