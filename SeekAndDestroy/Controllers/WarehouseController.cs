using MediatR;
using Microsoft.AspNetCore.Mvc;
using SAD.App.Warehouse;

namespace SeekAndDestroy.Controllers
{

    public class WarehouseController : Controller
    {
        private IMediator _mediator;

        public WarehouseController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> IndexWarehouse()
        {
            var warehouses = await _mediator.Send(new GetAllWareHouseQuery());
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