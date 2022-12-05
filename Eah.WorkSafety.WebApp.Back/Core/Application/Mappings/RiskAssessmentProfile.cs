using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Mappings
{
    public class RiskAssesmentProfile : Profile
    {
        public RiskAssesmentProfile()
        {
            this.CreateMap<RiskAssessment, RiskAssessmentDto>().ReverseMap();
        }
    }
}
