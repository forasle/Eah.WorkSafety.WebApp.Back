using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateMissionCommandHandler : IRequestHandler<UpdateMissionCommandRequest>
    {
        private readonly IRepository<Mission> repository;

        public UpdateMissionCommandHandler(IRepository<Mission> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateMissionCommandRequest request, CancellationToken cancellationToken)
        {
            Mission? mission = await this.repository.GetByIdAsync(x => x.Id == request.Id, x=>x.Users);
            if (mission != null)
            {
                mission.Name = request.Name;
                mission.Department = request.Department;
                mission.AssignerUserId = request.AssignerUserId;
                mission.Date = request.Date;
                mission.Deadline = request.Deadline;
                mission.Status = request.Status;

                var userMission = new List<UserMission>();
                if (request.AssignedUserIdList != null)
                {
                    foreach (var item in request.AssignedUserIdList)
                    {
                        userMission.Add(new UserMission()
                        {
                            UserId = item
                        });

                    }
                    mission.Users = userMission;
                }
                await this.repository.UpdateAsync(mission);
            }
            return Unit.Value;
        }
    }
}
