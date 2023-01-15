using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllInconsistencyByKeyQueryHandler : IRequestHandler<GetAllInconsistencyByKeyQueryRequest, List<InconsistencyDto>>
    {
        private readonly IRepository<Inconsistency> repository;
        private readonly IMapper mapper;

        public GetAllInconsistencyByKeyQueryHandler(IRepository<Inconsistency> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<InconsistencyDto>> Handle(GetAllInconsistencyByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            var count = await this.repository.GetAllCountAsync(x => x.Information!.Contains(request.Key));
            var data = await this.repository.GetAllByKeyWithPaginationAsync(request.Filter, x => x.Information!.Contains(request.Key));

            return this.mapper.Map<List<InconsistencyDto>>(data);
        }
    }
}
