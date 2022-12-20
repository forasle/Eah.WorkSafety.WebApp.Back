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
    public class InconsistencyController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IUriService uriService;

        public InconsistencyController(IMediator mediator, IUriService uriService)
        {
            this.mediator = mediator;
            this.uriService = uriService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateInconsistencyCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var result = await this.mediator.Send(new GetAllInconsistencyQueryRequest(filter));
            StatisticsDto statistics = await this.mediator.Send(new GetAllStatisticsQueryRequest());
            int? numberOfInconsistencies = statistics.NumberOfInconsistencies;
            var pagedReponse = PaginationHelper.CreatePagedReponse<InconsistencyDto>(result, validFilter, (int)numberOfInconsistencies!, uriService, route!);
            return Ok(pagedReponse);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetInconsistencyQueryRequest(id));
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateInconsistencyCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            await this.mediator.Send(new DeleteInconsistencyCommandRequest(id));
            return NoContent();
        }
    }
}
