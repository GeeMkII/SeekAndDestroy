using AutoMapper;
using SAD.App.Warehause;
using SAD.Domain.Interfaces;

namespace SAD.App.Services
{
    public class WarehauseService : IWarehauseService
        {
            private readonly IWarehauseRepo _warehouseRepo;
            private readonly IMapper _mapper;

            public WarehauseService(IWarehauseRepo warehouseRepo, IMapper mapper)
            {
                _warehouseRepo = warehouseRepo;
                _mapper = mapper;
            }
            public async Task Create(WarehauseDto warehouseDto)
            {//Łączymy warstwę App z Infrastruktórą przez warstwę domeny by zachować CLEAN arch.
             //Infrastruktóre/IWarehauseRepo
                var warehouse = _mapper.Map<Domain.Entities.Warehause>(warehouseDto);
                warehouse.SeoName();

                await _warehouseRepo.Create(warehouse);
            }

          // public Task Dellete()
           //     {
           //         throw new NotImplementedException();
           //     }

        public async Task<IEnumerable<WarehauseDto>> GetAll()
        {
            var warehouses = await _warehouseRepo.GetAll();
            var warehouseDtosMap = _mapper.Map<IEnumerable<WarehauseDto>>(warehouses);
            return warehouseDtosMap;
        }
    }
    }

