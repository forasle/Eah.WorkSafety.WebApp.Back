namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class CheckUserResponseDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = String.Empty;

        public string UserRole { get; set; } = String.Empty;

        public bool IsExist { get; set; }
    }
}
