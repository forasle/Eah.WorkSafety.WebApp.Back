using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, List<UserDto>>
    {
        private readonly IRepository<User> repository;
        private readonly IMapper mapper;

        public GetAllUserQueryHandler(IRepository<User> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<UserDto>> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllByPropertyWithPaginationAsync(request.Filter,x=>x.Missions,x=>x.Accidents,x=>x.NearMisses,x=>x.RiskAssessments,x=>x.ContingencyPlans,x=>x.Inconsistencies,x => x.PreventiveActivities);
            return this.mapper.Map<List<UserDto>>(data);
        }
    }
}
