using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using Eah.WorkSafety.WebApp.Back.Helpers;
using Eah.WorkSafety.WebApp.Back.Services;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Developer,Admin,Member,Operator,User")]
    public class NearMissController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IUriService uriService;

        public NearMissController(IMediator mediator, IUriService uriService)
        {
            this.mediator = mediator;
            this.uriService = uriService;
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateNearMissCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var result = await this.mediator.Send(new GetAllNearMissQueryRequest(filter));
            StatisticsDto statistics = await this.mediator.Send(new GetAllStatisticsQueryRequest());
            int? numberOfNearMisses = statistics.NumberOfNearMisses;
            var pagedReponse = PaginationHelper.CreatePagedReponse<NearMissDto>(result, validFilter, (int)numberOfNearMisses!, uriService, route!);
            return Ok(pagedReponse);
        }

        [HttpGet("{search}/{name}")]

        public async Task<IActionResult> Search([FromQuery] PaginationFilter filter, string key)
        {
            var route = Request.Path.Value + "?key=" + key;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var result = await this.mediator.Send(new GetAllNearMissByKeyQueryRequest(filter, key));
            var count = await this.mediator.Send(new GetAllNearMissCountByKeyQueryRequest(key));
            var pagedReponse = PaginationHelper.CreatePagedReponse<NearMissDto>(result, validFilter, count, uriService, route!);
            return Ok(pagedReponse);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetNearMissQueryRequest(id));
            return result == null ? NotFound() : Ok(result);
        }


        [HttpPut]
        public async Task<IActionResult> Update(UpdateNearMissCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await this.mediator.Send(new DeleteNearMissCommandRequest(id));
            return NoContent();
        }
    }
}
