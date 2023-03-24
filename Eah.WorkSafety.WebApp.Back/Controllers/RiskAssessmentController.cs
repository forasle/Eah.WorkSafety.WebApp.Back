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
    [Authorize(Roles = "Developer,Admin,Member,Operator,User")]
    public class RiskAssessmentController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IUriService uriService;
        public RiskAssessmentController(IMediator meditor, IUriService uriService)
        {
            this.mediator = meditor;
            this.uriService = uriService;
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateRiskAssessmentCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }


        [HttpGet]
        public async Task<IActionResult> List([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var result = await this.mediator.Send(new GetAllRiskAssessmentQueryRequest(filter));
            StatisticsDto statistics = await this.mediator.Send(new GetAllStatisticsQueryRequest());
            int? numberOfRiskAssessments = statistics.NumberOfRiskAssessments;
            var pagedReponse = PaginationHelper.CreatePagedReponse<RiskAssessmentDto>(result, validFilter, (int)numberOfRiskAssessments!, uriService, route!);
            return Ok(pagedReponse);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetRiskAssessmentQueryRequest(id));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateRiskAssessmentCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await this.mediator.Send(new DeleteRiskAssessmentCommandRequest(id));
            return NoContent();
        }
    }
}
