using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using System.Runtime.CompilerServices;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Mappings
{
    public class PersonProfile:Profile
    {
        public PersonProfile()
        {
            this.CreateMap<Person, PersonListDto>().ReverseMap();
        }
    }
}
