using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Mappings
{
    public class AccidentProfile : Profile
    {
        public AccidentProfile()
        {
            this.CreateMap<Accident, AccidentDto>().ForMember(x => x.AffectedEmployeeWithPropertyForAccident, opts => opts
        .MapFrom(x => x.Employees.Select(x => new AffectedEmployeeWithPropertyForAccident
        {
                EmployeeId = x.EmployeeId,
                LostDays = x.LostDays,
                Name = x.Employee!.Name,
                Surname = x.Employee!.Surname,
                IdentificationNumber = x.Employee!.IdentificationNumber,
                ThePrecautionsDisobeyingInstructions = x.ThePrecautionsDisobeyingInstructions,
                ThePrecautionsEquipmentUsageError = x.ThePrecautionsEquipmentUsageError,
                ThePrecautionsErrorInSafety = x.ThePrecautionsErrorInSafety,
                ThePrecautionsGiveOrReceiveFalseWarnings =x.ThePrecautionsGiveOrReceiveFalseWarnings,
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
                TheSubjectExposureToPhsicalViolence = x.TheSubjectExposureToPhsicalViolence,
                TheSubjectExposureToVerbalViolence = x.TheSubjectExposureToVerbalViolence,
                TheSubjectFallingImpactInjuries = x.TheSubjectFallingImpactInjuries,
                TheSubjectInjuredTrafficAccident = x.TheSubjectInjuredTrafficAccident,
                TheSubjectMaterialDamagedTrafficAccident = x.TheSubjectMaterialDamagedTrafficAccident,
                TheSubjectOfficeAccidents = x.TheSubjectOfficeAccidents,
                TheSubjectSharpObjectInjuries = x.TheSubjectSharpObjectInjuries
            }).ToList()
            ));
            /*
               this.CreateMap<Accident, AccidentDto>().ForMember(x => x.AffectedEmployeeWithProperty, opts => opts
               .MapFrom(x => x.Employees.Select(x=> new AffectedEmployeeWithProperty {Id = x.EmployeeId, LostDays=x.LostDays, ThePrecautionsToBeTakenOfEmployeeAccident = new Dto.ThePrecautionsToBeTakenOfEmployeeAccident { DisobeyingInstructions= x.ThePrecautionsToBeTakenOfEmployeeAccident!.DisobeyingInstructions,EquipmentUsageError = x.ThePrecautionsToBeTakenOfEmployeeAccident.EquipmentUsageError,ErrorInSafety=x.ThePrecautionsToBeTakenOfEmployeeAccident.ErrorInSafety,GiveOrReceiveFalseWarnings = x.ThePrecautionsToBeTakenOfEmployeeAccident.GiveOrReceiveFalseWarnings,ImproperSpeed = x.ThePrecautionsToBeTakenOfEmployeeAccident.ImproperSpeed,InsufficientMachineEquipmentEnclosure = x.ThePrecautionsToBeTakenOfEmployeeAccident.InsufficientMachineEquipmentEnclosure,NotUsingEquipmentProtectors = x.ThePrecautionsToBeTakenOfEmployeeAccident.NotUsingEquipmentProtectors, NotUsingPersonalProtectiveEquipment = x.ThePrecautionsToBeTakenOfEmployeeAccident.NotUsingPersonalProtectiveEquipment,TirednessOrInsomniaOrDrowsiness = x.ThePrecautionsToBeTakenOfEmployeeAccident.TirednessOrInsomniaOrDrowsiness, UsingFaultyEquipment = x.ThePrecautionsToBeTakenOfEmployeeAccident.UsingFaultyEquipment, WorkingInAnUnfamiliarField = x.ThePrecautionsToBeTakenOfEmployeeAccident.WorkingInAnUnfamiliarField, WorkingWithoutAuthorization = x.ThePrecautionsToBeTakenOfEmployeeAccident.WorkingWithoutAuthorization, WorkingWithoutDiscipline = x.ThePrecautionsToBeTakenOfEmployeeAccident.WorkingWithoutDiscipline}, 
                   TheSubjectOfTheAccidentOfEmployeeAccident= new Dto.TheSubjectOfTheAccidentOfEmployeeAccident { ElectricalAccidents = x.TheSubjectOfTheAccidentOfEmployeeAccident!.ElectricalAccidents, ExposureToBiologicalAgents = x.TheSubjectOfTheAccidentOfEmployeeAccident.ExposureToBiologicalAgents, ExposureToChemicals=x.TheSubjectOfTheAccidentOfEmployeeAccident.ExposureToChemicals, ExposureToFireAndBurn=x.TheSubjectOfTheAccidentOfEmployeeAccident.ExposureToFireAndBurn, ExposureToPhsicalViolence=x.TheSubjectOfTheAccidentOfEmployeeAccident.ExposureToPhsicalViolence,ExposureToVerbalViolence = x.TheSubjectOfTheAccidentOfEmployeeAccident.ExposureToVerbalViolence, FallingImpactInjuries=x.TheSubjectOfTheAccidentOfEmployeeAccident.FallingImpactInjuries, InjuredTrafficAccident=x.TheSubjectOfTheAccidentOfEmployeeAccident.InjuredTrafficAccident,MaterialDamagedTrafficAccident=x.TheSubjectOfTheAccidentOfEmployeeAccident.MaterialDamagedTrafficAccident,OfficeAccidents=x.TheSubjectOfTheAccidentOfEmployeeAccident.OfficeAccidents, SharpObjectInjuries = x.TheSubjectOfTheAccidentOfEmployeeAccident.SharpObjectInjuries}}).ToList()
               ));*/
            //MapperConfiguration.AssertConfigurationIsValid();

            /*
               this.CreateMap<Accident, AccidentDto>().ForMember(x => x.AffectedEmployeeWithProperty, opts => opts
               .MapFrom(x => x.Employees.Select(x => new AffectedEmployeeWithProperty
               {
                   Id = x.EmployeeId,
                   LostDays = x.LostDays,
                   ThePrecautionsToBeTakenOfEmployeeAccident = new Dto.ThePrecautionsToBeTakenOfEmployeeAccident { DisobeyingInstructions =true, EquipmentUsageError = true, ErrorInSafety = false, GiveOrReceiveFalseWarnings = false, ImproperSpeed = true, InsufficientMachineEquipmentEnclosure = true, NotUsingEquipmentProtectors = false, NotUsingPersonalProtectiveEquipment = true, TirednessOrInsomniaOrDrowsiness = false, UsingFaultyEquipment = false, WorkingInAnUnfamiliarField = true, WorkingWithoutAuthorization =true, WorkingWithoutDiscipline = false},
                   TheSubjectOfTheAccidentOfEmployeeAccident = new Dto.TheSubjectOfTheAccidentOfEmployeeAccident { ElectricalAccidents = false, ExposureToBiologicalAgents = true, ExposureToChemicals =false, ExposureToFireAndBurn = true, ExposureToPhsicalViolence = true, ExposureToVerbalViolence = false, FallingImpactInjuries = true, InjuredTrafficAccident = false, MaterialDamagedTrafficAccident = false, OfficeAccidents = true, SharpObjectInjuries = false }
               }).ToList()
               ));*/

        }

    }
}
