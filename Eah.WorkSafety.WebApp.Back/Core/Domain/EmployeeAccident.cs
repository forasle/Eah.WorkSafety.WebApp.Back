﻿namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class EmployeeAccident
    {
        public int EmployeeId { get; set; }

        public int AccidentId { get; set; }

        public int LostDays { get; set; }
        public Employee? Employee { get; set; }

        public Accident? Accident { get; set; }


        public ThePrecautionsToBeTakenOfEmployeeAccident? ThePrecautionsToBeTakenOfEmployeeAccident { get; set; }

        public TheSubjectOfTheAccidentOfEmployeeAccident? TheSubjectOfTheAccidentOfEmployeeAccident { get; set; }
        public EmployeeAccident()
        {
        }
    }
}
