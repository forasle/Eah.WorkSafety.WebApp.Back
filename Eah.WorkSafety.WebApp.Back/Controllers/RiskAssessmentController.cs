using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiskAssessmentController : ControllerBase
    {
        private readonly IMediator mediator;

        public RiskAssessmentController(IMediator meditor)
        {
            this.mediator = meditor;
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateRiskAssessmentCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpGet]

        public async Task<IActionResult> List()
        {
            var result = await this.mediator.Send(new GetAllRiskAssessmentQueryRequest());
            return Ok(result);
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
