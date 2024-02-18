using Microsoft.AspNetCore.Mvc;
using SAD.App.Services;
using SAD.App.Warehouse;

namespace SeekAndDestroy.Controllers
{

    public class WarehouseController : Controller
    {
        private readonly IWarehouseService _warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
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
        public async Task<IActionResult> Create(WarehouseDto warehouse)
            
        {
            warehouse.SEOName = warehouse.PalletRackName.ToLower().Replace(" ", "_") + "_" + warehouse.PalletRackPosition.ToLower().Replace(" ", "_");

              if (!ModelState.IsValid)
                {
                    return View(warehouse);
                }
            await _warehouseService.Create(warehouse);
            return RedirectToAction(nameof(IndexWarehouse)); 
        }
    }
}

    


//tu nie tworzymy konstruktora tworzącego elementy do magazynu ponieważ jest to tylko controler View(prezentacji). Przenosimy logikę do warstwy App\Services\WarehauseServices

//Przyjmujemy formularz jako obiekt od użytkownika