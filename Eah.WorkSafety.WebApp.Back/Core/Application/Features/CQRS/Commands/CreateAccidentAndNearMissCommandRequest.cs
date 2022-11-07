using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateAccidentAndNearMissCommandRequest:IRequest
    {
        public int Id { get; set; }

        public int AccidentNearMissNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? AccidentNearMissInfo { get; set; }

        public DateTime? Date { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public int LostDays { get; set; }


        public int IdentifierUserId { get; set; }

        public int AccidentOrNearMissTypeId { get; set; }
    }
}
