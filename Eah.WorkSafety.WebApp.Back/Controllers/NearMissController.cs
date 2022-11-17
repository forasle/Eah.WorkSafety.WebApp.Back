using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NearMissController : ControllerBase
    {
        private readonly IMediator mediator;

        public NearMissController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateNearMissCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await this.mediator.Send(new GetAllNearMissQueryRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetNearMissQueryRequest(id));
            return result == null ? NotFound() : Ok(result);
        }


        //    [HttpPut]
        //    public async Task<IActionResult> Update(UpdateAccidentAndNearmissCommandRequest request)
        //    {
        //        await this.mediator.Send(request);
        //        return NoContent();
        //    }

        //    [HttpDelete("{id}")]
        //    public async Task<IActionResult> Delete(int id)
        //    {
        //        var result = await this.mediator.Send(new DeleteAccidentAndNearMissCommandRequest(id));
        //        return NoContent();
        //    }
    }
}
