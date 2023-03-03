using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreatePreventiveActivityCommandRequest : IRequest
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Information { get; set; }

        public string? SceneOfPreventiveActivity { get; set; }

        public int CreatorUserId { get; set; }

        public bool Status { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public DateTime Deadline { get; set; }

        public DateTime PreventiveActivityDate { get; set; }

        public DateTime CreationDate { get; set; }

        public string? Method { get; set; }

    }
}
