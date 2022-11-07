using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await this.mediator.Send(new GetAllPersonQueryRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetPersonQueryRequest(id));
            return result == null ? NotFound() : Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this.mediator.Send(new DeletePersonCommandRequest(id));
            return NoContent();
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreatePersonCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("",request);
        }

        [HttpPut]

        public async Task<IActionResult> Update(UpdatePersonCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }
    }
}
