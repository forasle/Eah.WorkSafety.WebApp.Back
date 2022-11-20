using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContingencyPlanController : ControllerBase
    {
        private readonly IMediator mediator;

        public ContingencyPlanController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateContingencyPlanCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await this.mediator.Send(new GetAllContingencyPlansQueryRequest());
            return Ok(result);
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

        //[HttpDelete("{id}")]

        //public async Task<IActionResult> Delete(int id)
        //{
        //    var result = await this.mediator.Send(new DeleteContingencyPlanCommandRequest(id));
        //    return NoContent();
        //}
    }
}
