﻿namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class NearMiss
    {
        public int Id { get; set; }

        public int NearMissNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? NearMissInfo { get; set; }

        public DateTime? Date { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public int LostDays { get; set; }

        public int CreatorUserId { get; set; }

        public User? User { get; set; }

        public List<EmployeeNearMiss> Employees { get; set; }

        public NearMiss()
        {
            Employees = new List<EmployeeNearMiss>();
        }

    }
}
