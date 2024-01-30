using Microsoft.AspNetCore.Mvc;
using SAD.App.Services;

namespace SeekAndDestroy.Controllers
{
    public class WarehauseController : Controller
    {
        private readonly IWarehauseService _warehauseService;

        public WarehauseController(IWarehauseService warehauseService)
        {
            _warehauseService = warehauseService;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SAD.Domain.Entities.Warehause warehause)
        {
           await _warehauseService.Create(warehause);
            return RedirectToAction(nameof(Create)); //tymczasowo Create
        }
    }
}

    


//tu nie tworzymy konstruktora tworzącego elementy do magazynu ponieważ jest to tylko controler View(prezentacji). Przenosimy logikę do warstwy App\Services\WarehauseServices

//Przyjmujemy formularz jako obiekt od użytkownika