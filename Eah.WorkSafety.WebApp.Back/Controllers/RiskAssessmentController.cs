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
        private readonly IMediator meditor;

        public RiskAssessmentController(IMediator meditor)
        {
            this.meditor = meditor;
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateRiskAssessmentCommandRequest request)
        {
            await this.meditor.Send(request);
            return Created("",request);
        }

        [HttpGet]

        public async Task<IActionResult> List()
        {
            var result = await this.meditor.Send(new GetAllRiskAssessmentQueryRequest());
            return Ok(result);
        }
    }
}
