using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetOccupationDiseaseQueryRequest : IRequest<OccupationDiseaseDto>
    {
        public int Id { get; set; }

        public GetOccupationDiseaseQueryRequest(int id)
        {
            Id = id;
        }
    }
}
