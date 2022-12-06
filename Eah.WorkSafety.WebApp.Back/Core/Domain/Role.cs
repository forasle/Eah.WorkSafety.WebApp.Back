namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
<<<<<<<< HEAD:Eah.WorkSafety.WebApp.Back/Core/Domain/UserRole.cs
    public class UserRole
========
    public class Role
>>>>>>>> GoBackEntities:Eah.WorkSafety.WebApp.Back/Core/Domain/Role.cs
    {
        public int Id { get; set; }

        public string? Definition { get; set; }

<<<<<<<< HEAD:Eah.WorkSafety.WebApp.Back/Core/Domain/UserRole.cs
        public List<User>? AppUsers { get; set; }

        public UserRole()
        {
========
        public List<User>? Users { get; set; }

        public Role()
        {

>>>>>>>> GoBackEntities:Eah.WorkSafety.WebApp.Back/Core/Domain/Role.cs
        }
    }
}
