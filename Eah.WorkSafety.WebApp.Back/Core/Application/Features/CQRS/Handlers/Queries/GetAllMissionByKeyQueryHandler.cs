using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllMissionByKeyQueryHandler : IRequestHandler<GetAllMissionByKeyQueryRequest, List<MissionDto>>
    {
        private readonly IRepository<Mission> repository;
        private readonly IMapper mapper;

        public GetAllMissionByKeyQueryHandler(IRepository<Mission> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<MissionDto>> Handle(GetAllMissionByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            var count = await this.repository.GetAllCountAsync(x => x.Name!.Contains(request.Key));
            var data = await this.repository.GetAllByKeyWithPaginationAsync(request.Filter, x => x.Name!.Contains(request.Key),x=>x.Users);

            return this.mapper.Map<List<MissionDto>>(data);
        }
    }
}
