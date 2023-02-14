using Eah.WorkSafety.WebApp.Back.Core.Application.Enums;
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

        public Gender Gender { get; set; }

        public string? BirthPlace { get; set; }

        public string? Nationality { get; set; }

        public string? EducationStatus { get; set; }

        public string? RiskGroup { get; set; }

        public string? Title { get; set; }

        public string? Position { get; set; }

        public Department Department { get; set; }

        public DateTime? StartDateOfEmployment { get; set; }

        public string? Address { get; set; }

        public List<UpdateAffectedAccident>? UpdateAffectedAccident { get; set; }

        public List<UpdateAffectedNearMisses>? UpdateAffectedNearMisses { get; set; }

        public List<UpdateAffectedChronicDisease>? UpdateAffectedChronicDisease { get; set; }

        public List<UpdateAffectedOccupationDisease>? UpdateAffectedOccupationDisease { get; set; }

    }

    public class UpdateAffectedOccupationDisease
    {
        public int UpdateOccupationDiseaseId { get; set; }
    }

    public class UpdateAffectedChronicDisease
    {
        public int ChronicDiseaseId { get; set; }
    }

    public class UpdateAffectedAccident
    {
        public int AccidentId { get; set; }
    }
    public class UpdateAffectedNearMisses
    {
        public int NearMissId { get; set; }


    }
}

