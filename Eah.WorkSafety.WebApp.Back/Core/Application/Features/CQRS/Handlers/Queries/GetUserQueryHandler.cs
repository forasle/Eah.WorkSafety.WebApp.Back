using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQueryRequest, UserDto>
    {
        private readonly IRepository<User> repository;
        private readonly IMapper mapper;

        public GetUserQueryHandler(IRepository<User> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<UserDto> Handle(GetUserQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByIdAsync(x => x.Id == request.Id, x => x.Accidents, x => x.NearMisses, x => x.ContingencyPlans, x => x.RiskAssessments, x => x.Inconsistencies, x => x.Missions,x =>x.PreventiveActivities);
            return this.mapper.Map<UserDto>(data);

        }
    }
}
