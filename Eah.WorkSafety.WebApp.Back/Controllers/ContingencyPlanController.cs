using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using Eah.WorkSafety.WebApp.Back.Helpers;
using Eah.WorkSafety.WebApp.Back.Services;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Developer,Admin,Member,Operator,User")]
    public class ContingencyPlanController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IUriService uriService;

        public ContingencyPlanController(IMediator mediator, IUriService uriService)
        {
            this.mediator = mediator;
            this.uriService = uriService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateContingencyPlanCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var result = await this.mediator.Send(new GetAllContingencyPlansQueryRequest(filter));
            StatisticsDto statistics = await this.mediator.Send(new GetAllStatisticsQueryRequest());
            int? numberOfContingencyPlans = statistics.NumberOfContingencyPlans;
            var pagedReponse = PaginationHelper.CreatePagedReponse<ContingencyPlanDto>(result, validFilter, (int)numberOfContingencyPlans!, uriService, route!);
            return Ok(pagedReponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetContingencyPlanQueryRequest(id));
            return Ok(result);
        }

        [HttpPut]

        public async Task<IActionResult> Update(UpdateContingencyPlanCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            await this.mediator.Send(new DeleteContingencyPlanCommandRequest(id));
            return NoContent();
        }
    }
}
