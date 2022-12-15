using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands
{
    public class UpdateEmployeeCommandRequest : IRequest
    {
        public int Id { get; set; }

        public string? IdentificationNumber { get; set; }

        public string? RegistrationNumber { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public int? Age { get; set; }

        public string? BirthPlace { get; set; }

        public string? Nationality { get; set; }

        public string? EducationStatus { get; set; }

        public string? RiskGroup { get; set; }

        public string? Title { get; set; }

        public string? Position { get; set; }

        public string? Department { get; set; }

        public DateTime? StartDateOfEmployment { get; set; }

        public string? Address { get; set; }

        public Dictionary<int,int>? Accidents { get; set; }

        public Dictionary<int, int>? NearMisses { get; set; }

        public List<int>? OccupationDiseases { get; set; }

        public List<int>? ChronicDiseases { get; set; }
    }
}
