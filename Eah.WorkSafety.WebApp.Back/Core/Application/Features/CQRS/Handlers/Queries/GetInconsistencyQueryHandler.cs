using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using Microsoft.IdentityModel.Tokens;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetInconsistencyQueryHandler : IRequestHandler<GetInconsistencyQueryRequest, InconsistencyDto>
    {
        private readonly IRepository<Inconsistency> repository;
        private readonly IMapper mapper;

        public GetInconsistencyQueryHandler(IRepository<Inconsistency> repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<InconsistencyDto> Handle(GetInconsistencyQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            return this.mapper.Map<InconsistencyDto>(data);
        }
    }
}
