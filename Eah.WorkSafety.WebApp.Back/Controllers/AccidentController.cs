using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using Eah.WorkSafety.WebApp.Back.Core.Application.Wrappers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles ="Developer,Admin,Member,Operator,User,Visitor")]
    public class AccidentController : ControllerBase
    {
        private readonly IMediator mediator;

        public AccidentController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateAccidentCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery]PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var result = await this.mediator.Send(new GetAllAccidentQueryRequest(filter));
            return Ok(new PagedResponse<List<AccidentDto>>(result,validFilter.PageNumber,validFilter.PageSize));
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetAccidentQueryRequest(id));
            return result == null ? NotFound() : Ok(new Response<AccidentDto>(result));
        }


        [HttpPut]
        public async Task<IActionResult> Update(UpdateAccidentCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await this.mediator.Send(new DeleteAccidentCommandRequest(id));
            return NoContent();
        }
    }
}
