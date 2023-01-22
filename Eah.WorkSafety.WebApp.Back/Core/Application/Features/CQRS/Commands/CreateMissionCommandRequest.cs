﻿using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateMissionCommandRequest:IRequest
    {
        public string? Name { get; set; }

        public string? Department { get; set; }

        public int AssignerUserId { get; set; }

        public DateTime Date { get; set; }

        public DateTime Deadline { get; set; }

        public bool Status { get; set; }

        public CreateMissionCommandRequest()
        {
        }
        public List<CreateAssignedUser>? CreateAssignedUsers { get; set; }
    }
    public class CreateAssignedUser
    {
        public int UserId { get; set; }
    }
}