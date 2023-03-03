﻿using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateRiskAssessmentCommandRequest : IRequest
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Information { get; set; }

        public string? ReferenceNumber { get; set; }

        public int CreatorUserId { get; set; }

        public DateTime RevisionDate { get; set; }

        public DateTime RiskAssessmentDate { get; set; }

        public DateTime CreationDate { get; set; }

        public string? Method { get; set; }
    }
}
