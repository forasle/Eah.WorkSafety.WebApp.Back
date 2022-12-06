using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQueryRequest, List<EmployeeDto>>
    {
        private readonly IRepository<Employee> repository;
        private readonly IMapper mapper;

        public GetAllEmployeeQueryHandler(IRepository<Employee> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<EmployeeDto>> Handle(GetAllEmployeeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllByPropertyAsync(x => x.Accidents, x=>x.NearMisses,x=>x.ChronicDiseases,x=>x.OccupationDiseases);
            return this.mapper.Map<List<EmployeeDto>>(data);
        }
    }
}
