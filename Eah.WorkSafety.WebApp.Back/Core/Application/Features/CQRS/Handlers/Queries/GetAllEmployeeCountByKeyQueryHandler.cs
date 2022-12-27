using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetAllEmployeeCountByKeyQueryHandler : IRequestHandler<GetAllEmployeeCountByKeyQueryRequest, int>
    {
        private readonly IRepository<Employee> repository;
        private readonly IMapper mapper;

        public GetAllEmployeeCountByKeyQueryHandler(IRepository<Employee> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<int> Handle(GetAllEmployeeCountByKeyQueryRequest request, CancellationToken cancellationToken)
        {
            return await this.repository.GetAllCountAsync(x=>x.Name!.Contains(request.Key));
        }
    }
}
