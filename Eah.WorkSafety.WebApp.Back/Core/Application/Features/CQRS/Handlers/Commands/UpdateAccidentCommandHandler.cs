using Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Commands;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using MediatR;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Features.CQRS.Handlers.Commands
{
    public class UpdateAccidentCommandHandler : IRequestHandler<UpdateAccidentCommandRequest>
    {
        private readonly IRepository<Accident> accidentRepository;

        public UpdateAccidentCommandHandler(IRepository<Accident> repository)
        {
            this.accidentRepository = repository;
        }

        public async Task<Unit> Handle(UpdateAccidentCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.accidentRepository.GetByIdAsync(x=>x.Employees,x=>x.Id == request.Id);
            if (updatedEntity != null)
            {
                updatedEntity.AccidentNumber = request.AccidentNumber;
                updatedEntity.ReferenceNumber = request.ReferenceNumber;
                updatedEntity.AccidentInfo = request.AccidentInfo;
                updatedEntity.Date = request.Date;
                updatedEntity.RootCauseAnalysis = request.RootCauseAnalysis;
                updatedEntity.LostDays = request.LostDays;
                updatedEntity.CreatorUserId = request.CreatorUserId;
                if (request.AffectedEmployeeIdList != null)
                {
                    foreach (var item in updatedEntity.Employees)
                    {
                        if (!request.AffectedEmployeeIdList.Contains(item.EmployeeId)){
                            updatedEntity.Employees.Remove(item);
                        }
                        else
                        {
                            updatedEntity.Employees.Add(item);
                        }
                    }
                }

                await this.accidentRepository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;

        }
    }
}
