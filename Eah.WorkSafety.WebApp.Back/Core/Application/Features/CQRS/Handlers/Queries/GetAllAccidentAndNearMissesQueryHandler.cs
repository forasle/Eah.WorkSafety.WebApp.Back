using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllAccidentAndNearMissesQueryHandler : IRequestHandler<GetAllAccidentAndNearMissesQueryRequest, List<AccidentAndNearMissDto>>
    {
        private readonly IRepository<AccidentAndNearMiss> repository;
        private readonly IMapper mapper;

        public GetAllAccidentAndNearMissesQueryHandler(IRepository<AccidentAndNearMiss> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<AccidentAndNearMissDto>> Handle(GetAllAccidentAndNearMissesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllAsync();
            return this.mapper.Map<List<AccidentAndNearMissDto>>(data);
        }
    }
}
