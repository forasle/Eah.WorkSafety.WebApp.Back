using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using System;
using System.Runtime.CompilerServices;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            this.CreateMap<User, UserDto>().ForMember(x => x.Accidents, opts => opts
            .MapFrom(x => x.Accidents
            .Select(x=>x.Id)
            .ToList()
            )).ForMember(x => x.NearMisses, opts => opts
            .MapFrom(x => x.NearMisses
            .Select(x => x.Id)
            .ToList())).ForMember(x => x.RiskAssessments, opts => opts
            .MapFrom(x => x.RiskAssessments
            .Select(x => x.Id)
            .ToList())).ForMember(x => x.Inconsistencies, opts => opts
            .MapFrom(x => x.Inconsistencies
            .Select(x => x.Id)
            .ToList())).ForMember(x => x.Missions, opts => opts
            .MapFrom(x => x.Missions
            .Select(x => x.MissionId)
            .ToList())).ForMember(x => x.ContingencyPlans, opts => opts
            .MapFrom(x => x.ContingencyPlans
            .Select(x => x.Id)
            .ToList())).ForMember(x => x.PreventiveActivities, opts => opts
            .MapFrom(x => x.PreventiveActivities
            .Select(x => x.Id)
            .ToList()));
        }

    }
}
