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
                PerformedJob = request.PerformedJob,
                RelatedDepartment = request.RelatedDepartment,
                NeedFirstAid = request.NeedFirstAid,
                MedicalIntervention = request.MedicalIntervention,
                Eyewitnesses = request.Eyewitnesses,
                EyewitnessesName = request.EyewitnessesName,
                EyewitnessesPhoneNumber = request.EyewitnessesPhoneNumber,
                WitnessStatement = request.WitnessStatement,
                DuringOperation = request.DuringOperation,
                PropertyDamage = request.PropertyDamage,
                BusinessStopped = request.BusinessStopped,
                CameraRecording = request.CameraRecording,
                Date = request.Date,
                RootCauseAnalysis = request.RootCauseAnalysis,
                CreatorUserId = request.CreatorUserId,
            };
            if (request.CreateAffectedEmployeeWithPropertyForNearMiss != null)
            {
                foreach (var item in request.CreateAffectedEmployeeWithPropertyForNearMiss)
                {
                    nearMiss.Employees.Add(new EmployeeNearMiss()
                    {
                        EmployeeId = item.EmployeeId,
                        LostDays = item.LostDays
                    });
                }
            }

            await this.repository.CreateAsync(nearMiss);

            return Unit.Value;
        }
    }
}
