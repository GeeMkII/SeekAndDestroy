using AutoMapper;
using SAD.App.Warehause;
using SAD.Domain.Entities;

namespace SAD.App.Mappings
{
    public class WarehauseMappingProfile : Profile
    {
        public WarehauseMappingProfile()
        {
            CreateMap<WarehauseDto, Domain.Entities.Warehause>().ForMember(e => e.PalletRack, opt => opt.MapFrom(src => new PalletRack()
            {
                Name = src.PalletRackName,
                Position = src.PalletRackPosition,
            }));

            CreateMap<SAD.Domain.Entities.Warehause, WarehauseDto>()
                .ForMember(wd => wd.PalletRackName, opt => opt.MapFrom(src => src.PalletRack.Name))
                .ForMember(wd => wd.PalletRackPosition, opt => opt.MapFrom(src => src.PalletRack.Position));

        }
    }
}
