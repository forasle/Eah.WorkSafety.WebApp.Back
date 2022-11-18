using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateMissionCommandHandler : IRequestHandler<CreateMissionCommandRequest>
    {
        private readonly IRepository<Mission> repository;

        public CreateMissionCommandHandler(IRepository<Mission> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateMissionCommandRequest request, CancellationToken cancellationToken)
        {
            var mission = new Mission()
            {
                Name = request.Name,
                Department = request.Department,
                AssignerUserId = request.AssignerUserId,
                Date = request.Date,
                Deadline = request.Deadline,
                Status = request.Status, 
                
            };
            if (request.AssignedUserIdList != null)
            {
                foreach (var item in request.AssignedUserIdList)
                {
                    mission.Users.Add(new UserMission()
                    {
                        UserId = item
                    });

                }
            }
            await this.repository.CreateAsync(mission);

            return Unit.Value;
        }
    }
}
