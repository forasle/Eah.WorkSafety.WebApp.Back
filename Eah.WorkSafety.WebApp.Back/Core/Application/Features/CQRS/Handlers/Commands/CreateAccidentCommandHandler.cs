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
                ReferenceNumber = request.ReferenceNumber,
                AccidentInfo = request.AccidentInfo,
                PerformedJob=request.PerformedJob,
                RelatedDepartment=request.RelatedDepartment,
                NeedFirstAid=request.NeedFirstAid,
                MedicalIntervention=request.MedicalIntervention,
                Eyewitnesses=request.Eyewitnesses,
                EyewitnessesName=request.EyewitnessesName,
                EyewitnessesPhoneNumber=request.EyewitnessesPhoneNumber,
                WitnessStatement=request.WitnessStatement,
                DuringOperation=request.DuringOperation,
                PropertyDamage=request.PropertyDamage,
                BusinessStopped=request.BusinessStopped,
                CameraRecording=request.CameraRecording,
                Date = request.Date,
                RootCauseAnalysis = request.RootCauseAnalysis,
                CreatorUserId = request.CreatorUserId,
            };
            if (request.AffectedEmployeeIdWithLostDaysList != null)
            {
                foreach (var item in request.AffectedEmployeeIdWithLostDaysList)
                {
                    accident.Employees.Add(new EmployeeAccident()
                    {
                        EmployeeId = item.Key,
                        LostDays = item.Value,
                    });
                }
            }

            await this.repository.CreateAsync(accident);

            return Unit.Value;
        }
    }
}
