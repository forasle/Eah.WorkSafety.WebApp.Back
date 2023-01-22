using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllInconsistencyCountByKeyQueryHandler : IRequestHandler<GetAllInconsistencyCountByKeyQueryRequest, int>
    {
        private readonly IRepository<Inconsistency> repository;
        public GetAllInconsistencyCountByKeyQueryHandler(IRepository<Inconsistency> repository)
        {
            this.repository = repository;
        }

        public async Task<int> Handle(GetAllInconsistencyCountByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            return await this.repository.GetAllCountAsync(x => x.Information!.Contains(request.Key));
        }
    }
}
