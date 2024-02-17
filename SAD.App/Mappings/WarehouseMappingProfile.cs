using AutoMapper;
using SAD.App.Warehouse;
using SAD.Domain.Entities;

namespace SAD.App.Mappings
{
    public class WarehouseMappingProfile : Profile
    {
        public WarehouseMappingProfile()
        {
            CreateMap<WarehouseDto, Domain.Entities.Warehouse>().ForMember(e => e.PalletRack, opt => opt.MapFrom(src => new PalletRack()
            {
                Name = src.PalletRackName,
                Position = src.PalletRackPosition,
            }));

            CreateMap<Domain.Entities.Warehouse, WarehouseDto>()
                .ForMember(wd => wd.PalletRackName, opt => opt.MapFrom(src => src.PalletRack.Name))
                .ForMember(wd => wd.PalletRackPosition, opt => opt.MapFrom(src => src.PalletRack.Position));

        }
    }
}
