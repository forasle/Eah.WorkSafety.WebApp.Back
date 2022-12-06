﻿using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllPersonQueryHandler : IRequestHandler<GetAllPersonQueryRequest, List<PersonListDto>>
    {
        private readonly IRepository<Person> repository;
        private readonly IMapper mapper;

        public GetAllPersonQueryHandler(IRepository<Person> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<PersonListDto>> Handle(GetAllPersonQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllAsync();
            return this.mapper.Map<List<PersonListDto>>(data);
        }
    }
}
