using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllOccupationDiseaseByKeyQueryHandler : IRequestHandler<GetAllOccupationDiseaseByKeyQueryRequest, List<OccupationDiseaseDto>>
    {
        private readonly IRepository<OccupationDisease> repository;
        private readonly IMapper mapper;

        public GetAllOccupationDiseaseByKeyQueryHandler(IRepository<OccupationDisease> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<OccupationDiseaseDto>> Handle(GetAllOccupationDiseaseByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            var count = await this.repository.GetAllCountAsync(x => x.Diagnosis!.Contains(request.Key));
            var data = await this.repository.GetAllByKeyWithPaginationAsync(request.Filter, x => x.Diagnosis!.Contains(request.Key));

            return this.mapper.Map<List<OccupationDiseaseDto>>(data);
        }
    }
}
