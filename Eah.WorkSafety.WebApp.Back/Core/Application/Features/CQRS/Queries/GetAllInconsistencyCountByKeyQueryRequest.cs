using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllInconsistencyCountByKeyQueryRequest : IRequest<int>
    {
        public GetAllInconsistencyCountByKeyQueryRequest(string key)
        {
            Key = key;
        }

        public string Key { get; }
    }
}
