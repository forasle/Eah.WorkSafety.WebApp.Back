﻿using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetContingencyPlanQueryHandler : IRequestHandler<GetContingencyPlanQueryRequest, ContingencyPlanDto>
    {
        private readonly IRepository<ContingencyPlan> repository;
        private readonly IMapper mapper;

        public GetContingencyPlanQueryHandler(IRepository<ContingencyPlan> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ContingencyPlanDto> Handle(GetContingencyPlanQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            return this.mapper.Map<ContingencyPlanDto>(data);
        }
    }
}
