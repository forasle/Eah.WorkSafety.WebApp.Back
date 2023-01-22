using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllAccidentCountByKeyQueryHandler : IRequestHandler<GetAllAccidentCountByKeyQueryRequest, int>
    {
        private readonly IRepository<Accident> repository;


        public GetAllAccidentCountByKeyQueryHandler(IRepository<Accident> repository)
        {
            this.repository = repository;
        }

        public async Task<int> Handle(GetAllAccidentCountByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            return await this.repository.GetAllCountAsync(x => x.AccidentInfo!.Contains(request.Key));
        }
    }
}
