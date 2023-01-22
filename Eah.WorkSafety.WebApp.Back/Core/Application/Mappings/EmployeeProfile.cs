using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using System;
using System.Runtime.CompilerServices;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Mappings
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            this.CreateMap<Employee, EmployeeDto>().ForMember(x => x.AffectedAccident, opts => opts
            .MapFrom(x => x.Accidents.Select(x => new AffectedAccident { AccidentId = x.AccidentId }
            ).ToList()))
            .ForMember(x => x.AffectedNearMisses, opts => opts
            .MapFrom(x => x.NearMisses.Select(x => new AffectedNearMisses { NearMissId = x.NearMissId }
            ).ToList()))
            .ForMember(x => x.AffectedChronicDisease, opts => opts
            .MapFrom(x => x.ChronicDiseases.Select(x => new AffectedChronicDisease { ChronicDiseaseId = x.ChronicDiseaseId }
            ).ToList()))
            .ForMember(x => x.AffectedOccupationDisease, opts => opts
            .MapFrom(x => x.OccupationDiseases.Select(x => new AffectedOccupationDisease { OccupationDiseaseId = x.OccupationDiseaseId }
            ).ToList()));
        }

    }
}
