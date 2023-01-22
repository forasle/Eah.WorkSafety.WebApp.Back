using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class UpdateMissionCommandRequest:IRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Department { get; set; }

        public int AssignerUserId { get; set; }

        public DateTime Date { get; set; }

        public DateTime Deadline { get; set; }

        public bool Status { get; set; }

        public List<UpdateAssignedUser>? UpdateAssignedUsers { get; set; }
    }
    public class UpdateAssignedUser
    {
        public int UserId { get; set; }
    }
}