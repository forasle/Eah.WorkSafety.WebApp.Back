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
    public class PreventiveActivityController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IUriService uriService;

        public PreventiveActivityController(IMediator meditor, IUriService uriService)
        {
            this.mediator = meditor;
            this.uriService = uriService;
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreatePreventiveActivityCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var result = await this.mediator.Send(new GetAllPreventiveActivityQueryRequest(filter));
            StatisticsDto statistics = await this.mediator.Send(new GetAllStatisticsQueryRequest());
            int? numberOfPreventiveActivities = statistics.NumberOfPreventiveActivities;
            var pagedReponse = PaginationHelper.CreatePagedReponse<PreventiveActivityDto>(result, validFilter, (int)numberOfPreventiveActivities!, uriService, route!);
            return Ok(pagedReponse);
        }

        [HttpGet("{search}/{name}")]

        public async Task<IActionResult> Search([FromQuery] PaginationFilter filter, string key)
        {
            var route = Request.Path.Value + "?key=" + key;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var result = await this.mediator.Send(new GetAllPreventiveActivityByKeyQueryRequest(filter, key));
            var count = await this.mediator.Send(new GetAllPreventiveActivityCountByKeyQueryRequest(key));
            var pagedReponse = PaginationHelper.CreatePagedReponse<PreventiveActivityDto>(result, validFilter, count, uriService, route!);
            return Ok(pagedReponse);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetPreventiveActivityQueryRequest(id));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdatePreventiveActivityCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await this.mediator.Send(new DeletePreventiveActivityCommandRequest(id));
            return NoContent();
        }
    }
}
