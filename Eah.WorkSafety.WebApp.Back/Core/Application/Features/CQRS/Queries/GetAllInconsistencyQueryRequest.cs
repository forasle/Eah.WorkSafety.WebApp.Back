using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllInconsistencyQueryRequest : IRequest<List<InconsistencyDto>>
    {
    }
}
