namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class EmployeeNearMiss
    {
        public int EmployeeId { get; set; }

        public int NearMissId { get; set; }

        public int LostDays { get; set; }
        public Employee? Employee { get; set; }

        public NearMiss? NearMiss { get; set; }

        public EmployeeNearMiss()
        {
        }
    }
}
