// Ignore Spelling: Repo Dto App

using AutoMapper;
using SAD.App.Warehouse;
using SAD.Domain.Interfaces;

namespace SAD.App.Services
{
    public class WarehouseService : IWarehouseService
        {
            private readonly IWarehouseRepo _warehouseRepo;
            private readonly IMapper _mapper;

            public WarehouseService(IWarehouseRepo warehouseRepo, IMapper mapper)
            {
                _warehouseRepo = warehouseRepo;
                _mapper = mapper;
            }
            public async Task Create(WarehouseDto warehouseDto)
            {//Łączymy warstwę App z Infrastruktórą przez warstwę domeny by zachować CLEAN arch.
             //Infrastruktóre/IWarehauseRepo
                var warehouse = _mapper.Map<Domain.Entities.Warehouse>(warehouseDto);
                warehouse.SeoName();

                await _warehouseRepo.Create(warehouse);
            }

          // public Task Dellete()
           //     {
           //         throw new NotImplementedException();
           //     }

        public async Task<IEnumerable<WarehouseDto>> GetAll()
        {
            var warehouses = await _warehouseRepo.GetAll();
            var warehouseDtosMap = _mapper.Map<IEnumerable<WarehouseDto>>(warehouses);
            return warehouseDtosMap;
        }
    }
    }

