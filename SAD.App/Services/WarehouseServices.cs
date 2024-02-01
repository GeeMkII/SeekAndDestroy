using AutoMapper;
using SAD.App.Warehouse;
using SAD.Domain.Interfaces;

namespace SAD.App.Services
{
    public class WarehouseService : IWarehouseService
        {
            private readonly IWarehouseRepo _warehauseRepo;
            private readonly IMapper _mapper;

            public WarehouseService(IWarehouseRepo warehouseRepo, IMapper mapper)
            {
                _warehauseRepo = warehouseRepo;
                _mapper = mapper;
            }
            public async Task Create(Domain.Entities.Warehouse warehouse)
            {//Łączymy warstwę App z Infrastruktórą przez warstwę domeny by zachować CLEAN arch.
                //Infrastruktóre/IWarehauseRepo
                warehouse.SeoName();
                await _warehauseRepo.Create(warehouse);
            }

          // public Task Dellete()
           //     {
           //         throw new NotImplementedException();
           //     }

        public async Task<IEnumerable<WarehouseDto>> GetAll()
        {
            var warehouses = await _warehauseRepo.GetAll();
            var warehouseDtosMap = _mapper.Map<IEnumerable<WarehouseDto>>(warehouses);
            return warehouseDtosMap;
        }
    }
    }

