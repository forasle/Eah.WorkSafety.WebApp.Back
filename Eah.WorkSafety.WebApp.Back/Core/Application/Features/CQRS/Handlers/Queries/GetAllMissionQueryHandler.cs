using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllMissionsQueryHandler : IRequestHandler<GetAllMissionQueryRequest, List<MissionDto>>
    {
        private readonly IRepository<Mission> repository;
        private readonly IMapper mapper;

        public GetAllMissionsQueryHandler(IRepository<Mission> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<MissionDto>> Handle(GetAllMissionQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllByPropertyWithPaginationAsync(request.Filter,x => x.Users);
            return this.mapper.Map<List<MissionDto>>(data);
        }
    }
}
