using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllNearMissCountByKeyQueryRequest : IRequest<int>
    {
        public GetAllNearMissCountByKeyQueryRequest(string key)
        {
            Key = key;
        }

        public string Key { get; }
    }
}
