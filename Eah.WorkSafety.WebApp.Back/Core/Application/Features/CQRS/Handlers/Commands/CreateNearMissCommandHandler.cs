using Eah.WorkSafety.WebApp.Back.Core.Application.Enums;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System.Reflection;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateNearMissCommandHandler : IRequestHandler<CreateNearMissCommandRequest>
    {
        private readonly IRepository<NearMiss> repository;

        public CreateNearMissCommandHandler(IRepository<NearMiss> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateNearMissCommandRequest request, CancellationToken cancellationToken)
        {
            var nearMiss = new NearMiss
            {
                NearMissNumber = request.NearMissNumber,
                ReferenceNumber = request.ReferenceNumber,
                NearMissInfo = request.NearMissInfo,
                Date = request.Date,
                RootCauseAnalysis = request.RootCauseAnalysis,
                LostDays = request.LostDays,
                CreatorUserId = request.CreatorUserId,
            };
            if (request.AffectedEmployeeIdList != null)
            {
                foreach (var item in request.AffectedEmployeeIdList)
                {
                    nearMiss.Employees.Add(new EmployeeNearMiss()
                    {
                        EmployeeId = item
                    });
                }
            }

            await this.repository.CreateAsync(nearMiss);

            return Unit.Value;
        }
    }
}
