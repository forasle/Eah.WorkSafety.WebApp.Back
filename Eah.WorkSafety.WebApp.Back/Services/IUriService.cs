using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;

namespace Eah.WorkSafety.WebApp.Back.Services
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}
