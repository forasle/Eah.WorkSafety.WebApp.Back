﻿using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Eah.WorkSafety.WebApp.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChronicDiseaseController : ControllerBase
    {
        private readonly IMediator meditor;

        public ChronicDiseaseController(IMediator meditor)
        {
            this.meditor = meditor;
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateChronicDiseaseCommandRequest request)
        {
            await this.meditor.Send(request);
            return Created("", request);
        }
    }
}