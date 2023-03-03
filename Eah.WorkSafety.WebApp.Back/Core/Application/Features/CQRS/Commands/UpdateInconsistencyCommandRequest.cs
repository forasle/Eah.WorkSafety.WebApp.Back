using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class UpdateInconsistencyCommandRequest : IRequest
    {
        public int Id { get; set; }

        public string? SceneOfInconsistency { get; set; }

        public string? Information { get; set; }

        public int CreatorUserId { get; set; }

        public DateTime InconsistencyDate { get; set; }

        public bool RootCauseAnalysisRequirement { get; set; }

        public string? Department { get; set; }

        public bool Status { get; set; }

        public int RiskScore { get; set; }
    }
}
