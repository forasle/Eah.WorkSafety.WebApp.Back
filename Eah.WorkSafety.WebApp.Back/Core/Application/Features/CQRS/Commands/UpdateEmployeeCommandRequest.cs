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

        public string? Position { get; set; }

        public string? Department { get; set; }

        public DateTime? StartDateOfEmployment { get; set; }

        public string? Address { get; set; }

        public List<int>? Accidents { get; set; }

        public List<int>? NearMisses { get; set; }

        public List<int>? OccupationDiseases { get; set; }

        public List<int>? ChronicDiseases { get; set; }
    }
}
