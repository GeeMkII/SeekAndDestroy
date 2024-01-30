using SAD.Domain.Interfaces;

namespace SAD.App.Services
{
    public class WarehauseService : IWarehauseService
        {
            private readonly IWarehauseRepo _warehauseRepo;

            public WarehauseService(IWarehauseRepo warehauseRepo)
            {
                _warehauseRepo = warehauseRepo;
            }
            public async Task Create(Domain.Entities.Warehause warehause)
            {//Łączymy warstwę App z Infrastruktórą przez warstwę domeny by zachować CLEAN arch.
                //Infrastruktóre/IWarehauseRepo
                warehause.SeoName();
                await _warehauseRepo.Create(warehause);
            }
        }
    }

