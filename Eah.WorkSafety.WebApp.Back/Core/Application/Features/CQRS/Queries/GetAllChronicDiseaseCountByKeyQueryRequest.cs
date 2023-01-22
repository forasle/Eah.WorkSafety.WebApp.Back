using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllChronicDiseaseCountByKeyQueryRequest : IRequest<int>
    {
        public GetAllChronicDiseaseCountByKeyQueryRequest(string key)
        {
            Key = key;
        }

        public string Key { get; }
    }
}
