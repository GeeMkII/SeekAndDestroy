// Ignore Spelling: App

using AutoMapper;
using SAD.App.Warehouse;
using SAD.App.Warehouse.Commands.EditWareHouse;
using SAD.Domain.Entities;

namespace SAD.App.Mappings
{
    public class WarehouseMappingProfile : Profile
    {
        public WarehouseMappingProfile()
        {   // map z formularza dto do encji
            // automaper rozpozna jeśli są  te same nazwy i typy
            CreateMap<WarehouseDto, Domain.Entities.Warehouse>().ForMember(e => e.PalletRack, opt => opt.MapFrom(src => new PalletRack()
            {
                Name = src.PalletRackName,
                Position = src.PalletRackPosition,
            }));
            // map z encji do dto
            // automaper rozpozna jeśli są  te same nazwy i typy
            CreateMap<Domain.Entities.Warehouse, WarehouseDto>()
                .ForMember(wd => wd.PalletRackName, opt => opt.MapFrom(src => src.PalletRack.Name))
                .ForMember(wd => wd.PalletRackPosition, opt => opt.MapFrom(src => src.PalletRack.Position));

            CreateMap<WarehouseDto, EditWareHouseCmd>();

        }
    }
}
