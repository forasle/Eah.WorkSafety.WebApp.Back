using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllPreventiveActivityCountByKeyQueryRequest : IRequest<int>
    {
        public GetAllPreventiveActivityCountByKeyQueryRequest(string key)
        {
            Key = key;
        }

        public string Key { get; }
    }
}
