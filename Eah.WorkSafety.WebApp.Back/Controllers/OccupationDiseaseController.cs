using Azure.Core;
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
    public class OccupationDiseaseController : ControllerBase
    {
        private readonly IMediator mediator;

        public OccupationDiseaseController(IMediator meditor)
        {
            this.mediator = meditor;
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateOccupationDiseaseCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await this.mediator.Send(new GetAllOccupationDiseaseQueryRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetOccupationDiseaseQueryRequest(id));
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateOccupationDiseaseCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await this.mediator.Send(new DeleteOccupationDiseaseCommandRequest(id));
            return NoContent();
        }
    }
}
