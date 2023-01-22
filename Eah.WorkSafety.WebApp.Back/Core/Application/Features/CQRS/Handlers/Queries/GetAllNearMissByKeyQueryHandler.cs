using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllNearMissByKeyQueryHandler : IRequestHandler<GetAllNearMissByKeyQueryRequest, List<NearMissDto>>
    {
        private readonly IRepository<NearMiss> repository;
        private readonly IMapper mapper;

        public GetAllNearMissByKeyQueryHandler(IRepository<NearMiss> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<NearMissDto>> Handle(GetAllNearMissByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            var count = await this.repository.GetAllCountAsync(x => x.NearMissInfo!.Contains(request.Key));
            var data = await this.repository.GetAllByKeyWithPaginationAsync(request.Filter, x => x.NearMissInfo!.Contains(request.Key),x=>x.Employees);

            return this.mapper.Map<List<NearMissDto>>(data);
        }
    }
}
