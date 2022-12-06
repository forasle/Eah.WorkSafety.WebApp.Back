using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllOccupationDiseaseQueryHandler : IRequestHandler<GetAllOccupationDiseaseQueryRequest, List<OccupationDiseaseDto>>
    {
        private readonly IRepository<OccupationDisease> repository;
        private readonly IMapper mapper;

        public GetAllOccupationDiseaseQueryHandler(IRepository<OccupationDisease> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<OccupationDiseaseDto>> Handle(GetAllOccupationDiseaseQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllByPropertyAsync(x => x.Employees);
            return this.mapper.Map<List<OccupationDiseaseDto>>(data);
        }
    }
}
