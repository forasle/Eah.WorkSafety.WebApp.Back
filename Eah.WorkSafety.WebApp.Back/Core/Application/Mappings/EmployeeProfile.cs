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
            this.CreateMap<Employee, EmployeeDto>().ForMember(x=>x.Accidents,opts=>opts
            .MapFrom(x=>x.Accidents
            .Select(x=>x.AccidentId)
            .ToList())).ForMember(x => x.NearMisses, opts => opts
            .MapFrom(x => x.NearMisses
            .Select(x => x.NearMissId)
            .ToList())).ForMember(x => x.ChronicDisease, opts => opts
            .MapFrom(x => x.ChronicDiseases
            .Select(x => x.ChronicDiseaseId)
            .ToList())).ForMember(x => x.OccupationDisease, opts => opts
            .MapFrom(x => x.OccupationDiseases
            .Select(x => x.OccupationDiseaseId)
            .ToList()));
        }

    }
}
