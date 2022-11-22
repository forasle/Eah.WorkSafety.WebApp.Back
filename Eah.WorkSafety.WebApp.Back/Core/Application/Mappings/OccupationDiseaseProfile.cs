using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Mappings
{
    public class OccupationDiseaseProfile:Profile
    {
        public OccupationDiseaseProfile()
        {
            this.CreateMap<OccupationDisease, OccupationDiseaseDto>().ForMember(x=>x.Employees,opts=>opts
            .MapFrom(x=>x.Employees
            .Select(x=>x.EmployeeId)
            .ToList()));
        }
    }
}
