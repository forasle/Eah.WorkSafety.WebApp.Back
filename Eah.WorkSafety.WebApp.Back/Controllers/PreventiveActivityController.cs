using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreventiveActivityController : ControllerBase
    {
        private readonly IMediator mediator;

        public PreventiveActivityController(IMediator meditor)
        {
            this.mediator = meditor;
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreatePreventiveActivityCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]

        public async Task<IActionResult> List()
        {
            var result = await this.mediator.Send(new GetAllPreventiveActivityQueryRequest());
            return Ok(result);
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

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await this.mediator.Send(new DeletePreventiveActivityCommandRequest(id));
            return NoContent();
        }
    }
}
