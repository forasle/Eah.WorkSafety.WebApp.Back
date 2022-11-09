using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeleteRiskAssessmentCommandRequest:IRequest
    {
        public int Id { get; set; }

        public DeleteRiskAssessmentCommandRequest(int id)
        {
            Id = id;
        }
    }
}
