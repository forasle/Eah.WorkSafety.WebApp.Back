using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeleteOccupationDiseaseCommandRequest:IRequest
    {
        public int Id { get; set; }

        public DeleteOccupationDiseaseCommandRequest(int id)
        {
            Id = id;
        }
    }
}
