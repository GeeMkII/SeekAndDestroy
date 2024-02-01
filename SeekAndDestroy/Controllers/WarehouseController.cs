using Microsoft.AspNetCore.Mvc;
using SAD.App.Services;

namespace SeekAndDestroy.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly IWarehouseService _warehauseService;

        public WarehouseController(IWarehouseService warehauseService)
        {
            _warehauseService = warehauseService;
        }
        public async Task<IActionResult> IndexWarehause()
        {
            var warehauses = await _warehauseService.GetAll();
            return View(warehauses);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm]SAD.Domain.Entities.Warehouse warehause)
        {
           await _warehauseService.Create(warehause);
            return RedirectToAction(nameof(IndexWarehause)); //powrót do widoku
        }
    }
}

    


//tu nie tworzymy konstruktora tworzącego elementy do magazynu ponieważ jest to tylko controler View(prezentacji). Przenosimy logikę do warstwy App\Services\WarehauseServices

//Przyjmujemy formularz jako obiekt od użytkownika