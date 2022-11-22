using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllAccidentQueryHandler : IRequestHandler<GetAllAccidentQueryRequest, List<AccidentDto>>
    {
        private readonly IRepository<Accident> repository;
        private readonly IMapper mapper;

        public GetAllAccidentQueryHandler(IRepository<Accident> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<AccidentDto>> Handle(GetAllAccidentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllByPropertyAsync(x=>x.Employees);
            return this.mapper.Map<List<AccidentDto>>(data);
        }
    }
}
