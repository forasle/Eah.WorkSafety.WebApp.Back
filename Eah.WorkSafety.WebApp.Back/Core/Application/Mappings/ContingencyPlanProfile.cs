using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Mappings
{
    public class ContingencyPlanProfile:Profile
    {
        public ContingencyPlanProfile()
        {
            this.CreateMap<ContingencyPlan, ContingencyPlanDto>().ReverseMap();
        }
    }
}
