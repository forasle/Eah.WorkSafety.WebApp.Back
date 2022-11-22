using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Mappings
{
    public class ChronicDiseaseProfile : Profile
    {
        public ChronicDiseaseProfile()
        {
            this.CreateMap<ChronicDisease, ChronicDiseaseDto>().ForMember(x => x.Employees, opts => opts
            .MapFrom(x => x.Employees
            .Select(x => x.EmployeeId)
            .ToList())); ;
        }
    }
}
