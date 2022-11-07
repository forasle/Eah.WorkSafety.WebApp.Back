namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class Person
    {
        public int Id { get; set; }

        public string? IdentificationNumber { get; set; }

        public string? RegistrationNumber { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Position { get; set; }

        public string? Department { get; set; }

        public DateTime? StartDateOfEmployment { get; set; }

        public string? Address { get; set; }


        public List<PersonOccupationAndChronicDisease>? PersonOccupationAndChronicDiseases { get; set; }

        public List<PersonAccidentAndNearMiss>? PersonAccidentAndNearMisses { get; set; }

        public Person()
        {
        }
    }
}
