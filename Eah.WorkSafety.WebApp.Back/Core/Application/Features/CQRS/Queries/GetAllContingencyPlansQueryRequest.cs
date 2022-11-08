﻿using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllContingencyPlansQueryRequest:IRequest<List<ContingencyPlanDto>>
    {
    }
}
