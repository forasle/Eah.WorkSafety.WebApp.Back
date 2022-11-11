namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public UserRole Role { get; set; }

        public List<Mission> Missions { get; set; }

        public User()
        {
            Role = new UserRole();
            Missions= new List<Mission>();
        }
    }
}
