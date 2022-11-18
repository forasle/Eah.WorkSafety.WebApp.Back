using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Queries;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Eah.WorkSafety.WebApp.Back.Persistance.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography.Xml;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Queries
{
    public class GetMissionQueryHandler : IRequestHandler<GetMissionQueryRequest, MissionDto>
    {
        private readonly WorkSafetyDbContext work;
        private readonly IRepository<Mission> repository;
        private readonly IRepository<UserMission> userMissionRepository;
        private readonly IMapper mapper;

        public GetMissionQueryHandler(WorkSafetyDbContext work, IRepository<Mission> repository, IRepository<UserMission> userMissionRepository, IMapper mapper)
        {
            this.work = work;
            this.repository = repository;
            this.userMissionRepository = userMissionRepository;
            this.mapper = mapper;
        }

        public async Task<MissionDto> Handle(GetMissionQueryRequest request, CancellationToken cancellationToken)
        {
            //var missionUserData = await this.userMissionRepository.GetAllByFilterAsync(x => x.MissionId == request.Id);
            //var missionData = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            //var missionDto = this.mapper.Map<MissionDto>(missionData);
            //var userList =new List<int>();
            //foreach (var item in missionUserData)
            //{
            //    userList.Add(item.UserId);
            //}
            //var test = await this.work.Missions.Include(x=>x.Users).ThenInclude(x=>x.User).FirstAsync(x=>x.Id==request.Id);
            ////var test2= await this.repository.GetByFilterAsync2(x => x.Users);
            //missionDto.AssignedUserIdList = userList;
            var data = await this.repository.GetByIdAsync(x=>x.Users,x=>x.Id==request.Id);
            return this.mapper.Map<MissionDto>(data);
            
        }
    }
}
