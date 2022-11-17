using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetOccupationDiseaseQueryHandler : IRequestHandler<GetOccupationDiseaseQueryRequest, OccupationDiseaseDto>
    {
        private readonly IRepository<OccupationDisease> repository;
        private readonly IMapper mapper;

        public GetOccupationDiseaseQueryHandler(IRepository<OccupationDisease> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<OccupationDiseaseDto> Handle(GetOccupationDiseaseQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            return this.mapper.Map<OccupationDiseaseDto>(data);

        }
    }
}
