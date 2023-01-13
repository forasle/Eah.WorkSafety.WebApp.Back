using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllPreventiveActivityCountByKeyQueryHandler : IRequestHandler<GetAllPreventiveActivityCountByKeyQueryRequest, int>
    {
        private readonly IRepository<PreventiveActivity> repository;
        private readonly IMapper mapper;

        public GetAllPreventiveActivityCountByKeyQueryHandler(IRepository<PreventiveActivity> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<int> Handle(GetAllPreventiveActivityCountByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            return await this.repository.GetAllCountAsync(x => x.Information!.Contains(request.Key));
        }
    }
}
