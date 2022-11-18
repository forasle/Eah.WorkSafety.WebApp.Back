using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetChronicDiseaseQueryHandler : IRequestHandler<GetChronicDiseaseQueryRequest, ChronicDiseaseDto>
    {
        private readonly IRepository<ChronicDisease> repository;
        private readonly IMapper mapper;

        public GetChronicDiseaseQueryHandler(IRepository<ChronicDisease> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ChronicDiseaseDto> Handle(GetChronicDiseaseQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByIdAsync(x=>x.Employees,x => x.Id == request.Id);
            return this.mapper.Map<ChronicDiseaseDto>(data);

        }
    }
}
