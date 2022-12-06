using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class DeleteChronicDiseaseCommandRequest : IRequest
    {
        public int Id { get; set; }
        public DeleteChronicDiseaseCommandRequest(int id)
        {
            Id = id;
        }
    }
}
