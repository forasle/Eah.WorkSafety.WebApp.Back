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
    public class ChronicDiseaseController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IUriService uriService;

        public ChronicDiseaseController(IMediator meditor, IUriService uriService)
        {
            this.mediator = meditor;
            this.uriService = uriService;
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateChronicDiseaseCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var result = await this.mediator.Send(new GetAllChronicDiseaseQueryRequest(filter));
            StatisticsDto statistics = await this.mediator.Send(new GetAllStatisticsQueryRequest());
            int? numberOfChronicDisease = statistics.NumberOfChronicDisease;
            var pagedReponse = PaginationHelper.CreatePagedReponse<ChronicDiseaseDto>(result, validFilter, (int)numberOfChronicDisease!, uriService, route!);
            return Ok(pagedReponse);
        }

        [HttpGet("{search}/{name}")]

        public async Task<IActionResult> Search([FromQuery] PaginationFilter filter, string key)
        {
            var route = Request.Path.Value + "?key=" + key;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var result = await this.mediator.Send(new GetAllChronicDiseaseByKeyQueryRequest(filter, key));
            var count = await this.mediator.Send(new GetAllChronicDiseaseCountByKeyQueryRequest(key));
            var pagedReponse = PaginationHelper.CreatePagedReponse<ChronicDiseaseDto>(result, validFilter, count, uriService, route!);
            return Ok(pagedReponse);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetChronicDiseaseQueryRequest(id));
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateChronicDiseaseCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await this.mediator.Send(new DeleteChronicDiseaseCommandRequest(id));
            return NoContent();
        }
    }
}
