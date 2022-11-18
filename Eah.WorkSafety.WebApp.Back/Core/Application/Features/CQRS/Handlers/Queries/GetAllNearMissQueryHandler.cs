using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllNearMissQueryHandler : IRequestHandler<GetAllNearMissQueryRequest, List<NearMissDto>>
    {
        private readonly IRepository<NearMiss> repository;
        private readonly IMapper mapper;

        public GetAllNearMissQueryHandler(IRepository<NearMiss> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<NearMissDto>> Handle(GetAllNearMissQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllByFilterAsync(x=>x.Employees);
            return this.mapper.Map<List<NearMissDto>>(data);
        }
    }
}
