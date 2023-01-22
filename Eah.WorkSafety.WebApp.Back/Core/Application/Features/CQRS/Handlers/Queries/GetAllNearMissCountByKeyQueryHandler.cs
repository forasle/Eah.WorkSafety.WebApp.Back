using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllNearMissCountByKeyQueryHandler : IRequestHandler<GetAllNearMissCountByKeyQueryRequest, int>
    {
        private readonly IRepository<NearMiss> repository;

        public GetAllNearMissCountByKeyQueryHandler(IRepository<NearMiss> repository)
        {
            this.repository = repository;
        }

        public async Task<int> Handle(GetAllNearMissCountByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            return await this.repository.GetAllCountAsync(x => x.NearMissInfo!.Contains(request.Key));
        }
    }
}
