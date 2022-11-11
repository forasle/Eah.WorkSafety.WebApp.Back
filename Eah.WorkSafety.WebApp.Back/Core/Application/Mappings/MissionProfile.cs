using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Mappings
{
    public class MissionProfile:Profile
    {
        public MissionProfile()
        {
            this.CreateMap<Mission, MissionDto>().ReverseMap();
        }
    }
}
