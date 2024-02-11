using Microsoft.AspNetCore.Mvc;
using SAD.App.Services;
using SAD.App.Warehause;

namespace SeekAndDestroy.Controllers
{
    public class WarehauseController : Controller
    {
        private readonly IWarehauseService _warehouseService;

        public WarehauseController(IWarehauseService warehouseService)
        {
            _warehouseService = warehouseService;
        }
        public async Task<IActionResult> IndexWarehouse()
        {
            var warehouses = await _warehouseService.GetAll();
            return View(warehouses);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(WarehauseDto warehouse)
            
        {
            if (!ModelState.IsValid)
            {
                return View(warehouse);
            }
            await _warehouseService.Create(warehouse);
            return RedirectToAction(nameof(IndexWarehouse)); //tymczasowo Create
        }
    }
}

    


//tu nie tworzymy konstruktora tworzącego elementy do magazynu ponieważ jest to tylko controler View(prezentacji). Przenosimy logikę do warstwy App\Services\WarehauseServices

//Przyjmujemy formularz jako obiekt od użytkownika