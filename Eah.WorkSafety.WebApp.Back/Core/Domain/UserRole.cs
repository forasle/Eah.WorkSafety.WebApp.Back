namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class UserRole
    {
        public int Id { get; set; }

        public string? Definition { get; set; }

        public List<User>? AppUsers { get; set; }

        public UserRole()
        {
        }
    }
}
