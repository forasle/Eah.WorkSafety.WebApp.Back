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
            this.CreateMap<User, UserDto>().ForMember(x => x.UserAddedAccidents, opts => opts
            .MapFrom(x => x.Accidents.Select(x=> new UserAddedAccident { AccidentId = x.Id})
            .ToList())) 
            .ForMember(x => x.UserAddedNearMisses, opts => opts
            .MapFrom(x => x.NearMisses
            .Select(x => new UserAddedNearMiss { NearMissId = x.Id})
            .ToList()))
            .ForMember(x => x.UserAddedRiskAssessments, opts => opts
            .MapFrom(x => x.RiskAssessments
            .Select(x => new UserAddedRiskAssessment { RiskAssessmentId = x.Id})
            .ToList()))
            .ForMember(x => x.UserAddedInconsistencies, opts => opts
            .MapFrom(x => x.Inconsistencies
            .Select(x => new UserAddedInconsistency { InconsistencyId = x.Id})
            .ToList()))
            .ForMember(x => x.UserAddedMissions, opts => opts
            .MapFrom(x => x.Missions
            .Select(x => new UserAddedMission { MissionId = x.MissionId})
            .ToList()))
            .ForMember(x => x.UserAddedContingencyPlans, opts => opts
            .MapFrom(x => x.ContingencyPlans
            .Select(x => new UserAddedContingencyPlan { ContingencyPlanId = x.Id})
            .ToList())).ForMember(x => x.UserAddedPreventiveActivities, opts => opts
            .MapFrom(x => x.PreventiveActivities
            .Select(x => new UserAddedPreventiveActivity { PreventiveActivityId = x.Id})
            .ToList()));
        }

    }
}
