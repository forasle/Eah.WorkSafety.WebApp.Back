using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Mappings
{
    public class NearMissProfile : Profile
    {
        public NearMissProfile()
        {
            this.CreateMap<NearMiss, NearMissDto>().ForMember(x => x.AffectedEmployeeWithPropertyForNearMiss, opts => opts
            .MapFrom(x => x.Employees.Select(x=> new AffectedEmployeeWithPropertyForNearMiss
            {
                EmployeeId = x.EmployeeId,
                LostDays = x.LostDays,
                Name = x.Employee!.Name,
                Surname = x.Employee!.Surname,
                IdentificationNumber = x.Employee!.IdentificationNumber,
                ThePrecautionsDisobeyingInstructions = x.ThePrecautionsDisobeyingInstructions,
                ThePrecautionsEquipmentUsageError = x.ThePrecautionsEquipmentUsageError,
                ThePrecautionsErrorInSafety = x.ThePrecautionsErrorInSafety,
                ThePrecautionsGiveOrReceiveFalseWarnings = x.ThePrecautionsGiveOrReceiveFalseWarnings,
                ThePrecautionsImproperSpeed = x.ThePrecautionsImproperSpeed,
                ThePrecautionsInsufficientMachineEquipmentEnclosure = x.ThePrecautionsInsufficientMachineEquipmentEnclosure,
                ThePrecautionsNotUsingEquipmentProtectors = x.ThePrecautionsNotUsingEquipmentProtectors,
                ThePrecautionsNotUsingPersonalProtectiveEquipment = x.ThePrecautionsNotUsingPersonalProtectiveEquipment,
                ThePrecautionsTirednessOrInsomniaOrDrowsiness = x.ThePrecautionsTirednessOrInsomniaOrDrowsiness,
                ThePrecautionsUsingFaultyEquipment = x.ThePrecautionsUsingFaultyEquipment,
                ThePrecautionsWorkingInAnUnfamiliarField = x.ThePrecautionsWorkingInAnUnfamiliarField,
                ThePrecautionsWorkingWithoutAuthorization = x.ThePrecautionsWorkingWithoutAuthorization,
                ThePrecautionsWorkingWithoutDiscipline = x.ThePrecautionsWorkingWithoutDiscipline,

                TheSubjectElectricalAccidents = x.TheSubjectElectricalAccidents,
                TheSubjectExposureToBiologicalAgents = x.TheSubjectExposureToBiologicalAgents,
                TheSubjectExposureToChemicals = x.TheSubjectExposureToChemicals,
                TheSubjectExposureToFireAndBurn = x.TheSubjectExposureToFireAndBurn,
                TheSubjectExposureToPhysicalViolence = x.TheSubjectExposureToPhysicalViolence,
                TheSubjectExposureToVerbalViolence = x.TheSubjectExposureToVerbalViolence,
                TheSubjectFallingImpactInjuries = x.TheSubjectFallingImpactInjuries,
                TheSubjectInjuredTrafficAccident = x.TheSubjectInjuredTrafficAccident,
                TheSubjectMaterialDamagedTrafficAccident = x.TheSubjectMaterialDamagedTrafficAccident,
                TheSubjectOfficeAccidents = x.TheSubjectOfficeAccidents,
                TheSubjectSharpObjectInjuries = x.TheSubjectSharpObjectInjuries
            }).ToList()
            ));

        }
    }
}
