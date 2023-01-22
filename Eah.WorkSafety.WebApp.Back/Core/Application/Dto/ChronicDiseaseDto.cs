﻿using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class ChronicDiseaseDto
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Diagnosis { get; set; }

        public List<AffectedEmployeeByChronicDisease>? AffectedEmployeeByChronicDisease { get; set; }
    }
    public class AffectedEmployeeByChronicDisease
    {
        public int EmployeeId { get; set; }
    }
}
