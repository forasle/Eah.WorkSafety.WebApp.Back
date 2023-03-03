using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllContingencyPlansQueryHandler : IRequestHandler<GetAllContingencyPlansQueryRequest, List<ContingencyPlanDto>>
    {
        private readonly IRepository<ContingencyPlan> repository;
        private readonly IMapper mapper;

        public GetAllContingencyPlansQueryHandler(IRepository<ContingencyPlan> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<ContingencyPlanDto>> Handle(GetAllContingencyPlansQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllWithPaginationAsync(request.Filter,x=>x.CreationDate);
            return this.mapper.Map<List<ContingencyPlanDto>>(data);
        }
    }
}
