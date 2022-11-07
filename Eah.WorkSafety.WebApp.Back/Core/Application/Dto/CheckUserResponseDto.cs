namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class CheckUserResponseDto
    {
        public int Id { get; set; }
        public string? Username { get; set; }

        public string? UserRole { get; set; }

        public bool IsExist { get; set; }
    }
}
