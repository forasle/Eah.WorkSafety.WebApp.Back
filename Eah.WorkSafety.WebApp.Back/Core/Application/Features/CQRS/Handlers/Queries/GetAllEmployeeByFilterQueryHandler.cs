using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllEmployeeByFilterQueryHandler : IRequestHandler<GetAllEmployeeByFilterQueryRequest, List<EmployeeDto>>
    {
        private readonly IRepository<Employee> repository;
        private readonly IMapper mapper;

        public GetAllEmployeeByFilterQueryHandler(IRepository<Employee> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<EmployeeDto>> Handle(GetAllEmployeeByFilterQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllByFilterAsync(x=>x.Name.Contains(request.Filter));
            return this.mapper.Map<List<EmployeeDto>>(data);
        }
    }
}
