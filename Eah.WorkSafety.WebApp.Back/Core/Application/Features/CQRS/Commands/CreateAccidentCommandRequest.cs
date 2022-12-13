using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateAccidentCommandRequest : IRequest
    {
        public int Id { get; set; }

        public int AccidentNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? AccidentInfo { get; set; }

        public DateTime? Date { get; set; }

        public bool RootCauseAnalysis { get; set; }


        public int CreatorUserId { get; set; }

        public Dictionary<int,int>? AffectedEmployeeIdWithLostDaysList { get; set; }
    }
}
