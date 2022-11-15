using Eah.WorkSafety.WebApp.Back.Core.Application.Enums;
using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;
using System.Reflection;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class CreateAccidentCommandHandler : IRequestHandler<CreateAccidentCommandRequest>
    {
        private readonly IRepository<Accident> repository;

        public CreateAccidentCommandHandler(IRepository<Accident> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateAccidentCommandRequest request, CancellationToken cancellationToken)
        {
            var accident = new Accident
            {
                AccidentNumber = request.AccidentNumber,
                ReferenceNumber = request.ReferenceNumber,
                AccidentInfo = request.AccidentInfo,
                Date = request.Date,
                RootCauseAnalysis = request.RootCauseAnalysis,
                LostDays = request.LostDays,
                CreatorUserId = request.CreatorUserId,
            };
            if (request.AffectedEmployeeIdList != null)
            {
                foreach (var item in request.AffectedEmployeeIdList)
                {
                    accident.Employees.Add(new EmployeeAccident()
                    {
                        EmployeeId = item
                    });
                }
            }

            await this.repository.CreateAsync(accident);

            return Unit.Value;
        }
    }
}
