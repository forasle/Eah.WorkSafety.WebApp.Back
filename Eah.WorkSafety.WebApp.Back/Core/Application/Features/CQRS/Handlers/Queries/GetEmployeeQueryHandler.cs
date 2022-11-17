using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQueryRequest, EmployeeDto>
    {
        private readonly IRepository<Employee> repository;
        private readonly IMapper mapper;

        public GetEmployeeQueryHandler(IRepository<Employee> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<EmployeeDto> Handle(GetEmployeeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            return this.mapper.Map<EmployeeDto>(data);
        }
    }
}
