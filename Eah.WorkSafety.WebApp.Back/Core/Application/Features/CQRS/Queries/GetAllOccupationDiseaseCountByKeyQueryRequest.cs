using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllOccupationDiseaseCountByKeyQueryRequest : IRequest<int>
    {
        public GetAllOccupationDiseaseCountByKeyQueryRequest(string key)
        {
            Key = key;
        }

        public string Key { get; }
    }
}
