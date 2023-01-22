﻿using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateNearMissCommandRequest : IRequest
    {
        public int Id { get; set; }

        public int NearMissNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? NearMissInfo { get; set; }

        public string? PerformedJob { get; set; }

        public string? RelatedDepartment { get; set; }

        public bool? NeedFirstAid { get; set; }

        public bool? MedicalIntervention { get; set; }

        public bool? Eyewitnesses { get; set; }

        public string? EyewitnessesName { get; set; }

        public string? EyewitnessesPhoneNumber { get; set; }

        public string? WitnessStatement { get; set; }

        public bool? DuringOperation { get; set; }

        public bool? PropertyDamage { get; set; }

        public bool? BusinessStopped { get; set; }

        public bool? CameraRecording { get; set; }

        public DateTime? Date { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public int CreatorUserId { get; set; }

        public List<CreateAffectedEmployeeWithPropertyForNearMiss>? CreateAffectedEmployeeWithPropertyForNearMiss { get; set; }

    }
    public class CreateAffectedEmployeeWithPropertyForNearMiss
    {
        public int EmployeeId { get; set; }
        public int LostDays { get; set; }

    }
}