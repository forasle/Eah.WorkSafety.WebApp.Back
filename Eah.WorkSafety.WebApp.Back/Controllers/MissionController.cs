using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MissionController : ControllerBase
    {
        private readonly IMediator mediator;

        public MissionController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMissionCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("",request);
        }
    }
}
