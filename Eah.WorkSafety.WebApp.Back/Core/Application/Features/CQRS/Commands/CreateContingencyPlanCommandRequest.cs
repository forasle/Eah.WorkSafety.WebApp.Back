using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateContingencyPlanCommandRequest:IRequest
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int PlanNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Information { get; set; }

        public int CreatorUserId { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? CreationTime { get; set; }
    }
}
