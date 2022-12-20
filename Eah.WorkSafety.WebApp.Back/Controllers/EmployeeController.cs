using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using Eah.WorkSafety.WebApp.Back.Helpers;
using Eah.WorkSafety.WebApp.Back.Services;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IUriService uriService;
        public EmployeeController(IMediator mediator, IUriService uriService)
        {
            this.mediator = mediator;
            this.uriService = uriService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var result = await this.mediator.Send(new GetAllEmployeeQueryRequest(filter));
            StatisticsDto statistics = await this.mediator.Send(new GetAllStatisticsQueryRequest());
            int? numberOfEmployee = statistics.NumberOfEmployee;
            var pagedReponse = PaginationHelper.CreatePagedReponse<EmployeeDto>(result, validFilter, (int)numberOfEmployee!, uriService, route!);
            return Ok(pagedReponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetEmployeeQueryRequest(id));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateEmployeeCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await this.mediator.Send(new DeleteEmployeeCommandRequest(id));
            return NoContent();
        }
    }
}
