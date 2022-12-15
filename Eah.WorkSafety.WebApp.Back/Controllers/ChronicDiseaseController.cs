using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class ChronicDiseaseController : ControllerBase
    {
        private readonly IMediator mediator;

        public ChronicDiseaseController(IMediator meditor)
        {
            this.mediator = meditor;
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateChronicDiseaseCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await this.mediator.Send(new GetAllChronicDiseaseQueryRequest());
            return Ok(result);
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
