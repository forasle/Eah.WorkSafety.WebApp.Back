using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllChronicDiseaseQueryHandler : IRequestHandler<GetAllChronicDiseaseQueryRequest, List<ChronicDiseaseDto>>
    {
        private readonly IRepository<ChronicDisease> repository;
        private readonly IMapper mapper;

        public GetAllChronicDiseaseQueryHandler(IRepository<ChronicDisease> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<ChronicDiseaseDto>> Handle(GetAllChronicDiseaseQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllByFilterAsync(x=>x.Employees);
            return this.mapper.Map<List<ChronicDiseaseDto>>(data);
        }
    }
}
