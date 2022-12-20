using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using Eah.WorkSafety.WebApp.Back.Helpers;
using Eah.WorkSafety.WebApp.Back.Services;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IUriService uriService;

        public UserController(IMediator mediator, IUriService uriService)
        {
            this.mediator = mediator;
            this.uriService = uriService;
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var result = await this.mediator.Send(new GetAllUserQueryRequest(filter));
            StatisticsDto statistics = await this.mediator.Send(new GetAllStatisticsQueryRequest());
            int? numberOfUser = statistics.NumberOfUser;
            var pagedReponse = PaginationHelper.CreatePagedReponse<UserDto>(result, validFilter, (int)numberOfUser!, uriService, route!);
            return Ok(pagedReponse);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetUserQueryRequest(id));
            return Ok(result);
        }
    }
}
