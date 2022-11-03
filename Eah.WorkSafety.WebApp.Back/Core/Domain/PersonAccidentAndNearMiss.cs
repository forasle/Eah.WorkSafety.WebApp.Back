namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class PersonAccidentAndNearMiss
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int AccidentAndNearMissId { get; set; }

        public AccidentAndNearMiss AccidentAndNearMiss { get; set; }


        public PersonAccidentAndNearMiss()
        {
            Person = new Person();
            AccidentAndNearMiss = new AccidentAndNearMiss();
        }
    }
}
