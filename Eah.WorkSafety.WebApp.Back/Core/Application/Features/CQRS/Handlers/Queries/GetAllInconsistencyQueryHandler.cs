﻿using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllInconsistencyQueryHandler : IRequestHandler<GetAllInconsistencyQueryRequest, List<InconsistencyDto>>
    {
        private readonly IRepository<Inconsistency> repository;
        private readonly IMapper mapper;

        public GetAllInconsistencyQueryHandler(IRepository<Inconsistency> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<InconsistencyDto>> Handle(GetAllInconsistencyQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllWithPaginationAsync(request.Filter);
            return this.mapper.Map<List<InconsistencyDto>>(data);
        }
    }
}
