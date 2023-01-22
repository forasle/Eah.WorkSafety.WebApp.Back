using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllMissionCountByKeyQueryHandler : IRequestHandler<GetAllMissionCountByKeyQueryRequest, int>
    {
        private readonly IRepository<Mission> repository;

        public GetAllMissionCountByKeyQueryHandler(IRepository<Mission> repository)
        {
            this.repository = repository;
        }

        public async Task<int> Handle(GetAllMissionCountByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            return await this.repository.GetAllCountAsync(x => x.Name!.Contains(request.Key));
        }
    }
}
