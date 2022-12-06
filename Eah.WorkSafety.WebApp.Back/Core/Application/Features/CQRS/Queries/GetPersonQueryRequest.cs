using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetPersonQueryRequest:IRequest<PersonListDto>
    {
        public int Id { get; set; }

        public GetPersonQueryRequest(int id)
        {
            Id = id;
        }
    }
}
