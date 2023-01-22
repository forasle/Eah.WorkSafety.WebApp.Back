using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllChronicDiseaseCountByKeyQueryHandler : IRequestHandler<GetAllChronicDiseaseCountByKeyQueryRequest, int>
    {
        private readonly IRepository<ChronicDisease> repository;


        public GetAllChronicDiseaseCountByKeyQueryHandler(IRepository<ChronicDisease> repository)
        {
            this.repository = repository;
        }

        public async Task<int> Handle(GetAllChronicDiseaseCountByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            return await this.repository.GetAllCountAsync(x => x.Diagnosis!.Contains(request.Key));
        }
    }
}
