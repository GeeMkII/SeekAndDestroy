using AutoMapper;
using SAD.App.Warehause;
using SAD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Mappings
{
    public class WarehauseMappingProfile : Profile
    {
        public WarehauseMappingProfile()
        {
            CreateMap<WarehauseDto, SAD.Domain.Entities.Warehause>().ForMember(e => e.PalletRack, opt => opt.MapFrom(src => new PalletRack()
            {
                Name = src.PalletRackName,
                Position = src.PalletRackPosition,
            }));
        }
    }
}
