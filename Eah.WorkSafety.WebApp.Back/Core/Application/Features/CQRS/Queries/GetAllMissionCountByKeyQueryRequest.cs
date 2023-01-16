using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllMissionCountByKeyQueryRequest : IRequest<int>
    {
        public GetAllMissionCountByKeyQueryRequest(string key)
        {
            Key = key;
        }

        public string Key { get; }
    }
}
