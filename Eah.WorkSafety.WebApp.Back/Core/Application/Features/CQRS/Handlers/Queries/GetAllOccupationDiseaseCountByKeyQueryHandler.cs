using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllOccupationDiseaseCountByKeyQueryHandler : IRequestHandler<GetAllOccupationDiseaseCountByKeyQueryRequest, int>
    {
        private readonly IRepository<OccupationDisease> repository;


        public GetAllOccupationDiseaseCountByKeyQueryHandler(IRepository<OccupationDisease> repository)
        {
            this.repository = repository;
        }

        public async Task<int> Handle(GetAllOccupationDiseaseCountByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            return await this.repository.GetAllCountAsync(x => x.Diagnosis!.Contains(request.Key));
        }
    }
}
