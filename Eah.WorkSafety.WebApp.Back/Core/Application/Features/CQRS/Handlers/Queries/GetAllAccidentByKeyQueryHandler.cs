using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllAccidentByKeyQueryHandler : IRequestHandler<GetAllAccidentByKeyQueryRequest, List<AccidentDto>>
    {
        private readonly IRepository<Accident> repository;
        private readonly IMapper mapper;

        public GetAllAccidentByKeyQueryHandler(IRepository<Accident> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<AccidentDto>> Handle(GetAllAccidentByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            var count = await this.repository.GetAllCountAsync(x => x.AccidentInfo!.Contains(request.Key));
            var data = await this.repository.GetAllByKeyWithPaginationAsync(request.Filter, x => x.AccidentInfo!.Contains(request.Key));

            return this.mapper.Map<List<AccidentDto>>(data);
        }
    }
}
