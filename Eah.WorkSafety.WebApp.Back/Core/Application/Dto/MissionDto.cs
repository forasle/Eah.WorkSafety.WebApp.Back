﻿using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class MissionDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Department { get; set; }

        public int AssignerUserId { get; set; }

        public DateTime Date { get; set; }

        public DateTime Deadline { get; set; }

        public bool Status { get; set; }
        public MissionDto()
        {
        }
        public List<AssignedUser>? AssignedUsers { get; set; }
    }
    public class AssignedUser
    {
        public int UserId { get; set; }
    }
}
