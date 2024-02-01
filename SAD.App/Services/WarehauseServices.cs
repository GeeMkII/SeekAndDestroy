using AutoMapper;
using SAD.App.Warehause;
using SAD.Domain.Interfaces;

namespace SAD.App.Services
{
    public class WarehauseService : IWarehauseService
        {
            private readonly IWarehauseRepo _warehauseRepo;
            private readonly IMapper _mapper;

            public WarehauseService(IWarehauseRepo warehauseRepo, IMapper mapper)
            {
                _warehauseRepo = warehauseRepo;
                _mapper = mapper;
            }
            public async Task Create(Domain.Entities.Warehause warehause)
            {//Łączymy warstwę App z Infrastruktórą przez warstwę domeny by zachować CLEAN arch.
                //Infrastruktóre/IWarehauseRepo
                warehause.SeoName();
                await _warehauseRepo.Create(warehause);
            }

          // public Task Dellete()
           //     {
           //         throw new NotImplementedException();
           //     }

        public async Task<IEnumerable<WarehauseDto>> GetAll()
        {
            var warehauses = await _warehauseRepo.GetAll();
            var warehauseDtosMap = _mapper.Map<IEnumerable<WarehauseDto>>(warehauses);
            return warehauseDtosMap;
        }
    }
    }

