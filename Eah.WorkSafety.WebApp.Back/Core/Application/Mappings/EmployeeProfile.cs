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
            this.CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }
}
