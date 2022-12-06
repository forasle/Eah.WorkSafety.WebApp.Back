using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetChronicDiseaseQueryRequest : IRequest<ChronicDiseaseDto>
    {
        public int Id { get; set; }

        public GetChronicDiseaseQueryRequest(int id)
        {
            Id = id;
        }
    }
}
