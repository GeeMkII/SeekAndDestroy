using MediatR;
using Microsoft.AspNetCore.Mvc;
using SAD.App.Warehouse.Comands.CretaPlates;
using SAD.App.Warehouse.Queries.GetAllPlates;
using SAD.App.Warehouse.Queries.GetAllPlates.GetById;

namespace SeekAndDestroy.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly IMediator _mediator;

        public WarehouseController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> IndexWarehouse()
        {
            var warehouses = await _mediator.Send(new GetAllPlatesQuery());
            return View(warehouses);
        }
        public IActionResult Create()
        {
            return View();
        }
        [Route("Warehouse/(plateId)/Details")]
        public async Task<IActionResult> Details(int plateId)
        {
            var dto = await _mediator.Send(new GetPlateById(plateId));
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePlatesCmd command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }
           await _mediator.Send(command);
            return RedirectToAction(nameof(IndexWarehouse)); //powrót do widoku
        }
    }
}

    


//tu nie tworzymy konstruktora tworzącego elementy do magazynu ponieważ jest to tylko controler View(prezentacji). Przenosimy logikę do warstwy App\Services\WarehauseServices

//Przyjmujemy formularz jako obiekt od użytkownika