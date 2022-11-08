﻿using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class ContingencyPlanDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int PlanNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Information { get; set; }

        public User? Identifier { get; set; }

        public int IdentifierUserId { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? CreationTime { get; set; }
    }
}
