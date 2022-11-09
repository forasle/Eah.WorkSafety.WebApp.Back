using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateMissionCommandRequest:IRequest
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Department { get; set; }

        public int AssignerUserId { get; set; }

        public int AssignedUserId { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? Deadline { get; set; }

        public bool Status { get; set; }

    }
}
