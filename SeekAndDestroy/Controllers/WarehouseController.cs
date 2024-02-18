using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SAD.App.Warehouse.Commands.CreateWareHouse;
using SAD.App.Warehouse.Commands.EditWareHouse;
using SAD.App.Warehouse.Queries.GetAllWareHouses;
using SAD.App.Warehouse.Queries.GetWarHouseBySEO;

namespace SeekAndDestroy.Controllers
{

    public class WarehouseController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public WarehouseController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexWarehouse()
        {
            var warehouses = await _mediator.Send(new GetAllWareHousesQuery());
            return View(warehouses);
        }
        public IActionResult Create()
        {
            return View();
        }

        [Route("WareHouse/{SEOName}/Details")]
        public async Task<IActionResult> Details(string seoName)
        {
         
            var dto = await _mediator.Send(new GetWarHouseBySeoQuery(seoName));
            return View(dto);
        }

        [Route("WareHouse/{SEOName}/Edit")]
        public async Task<IActionResult> Edit(string seoName)
        {

            var dto = await _mediator.Send(new GetWarHouseBySeoQuery(seoName));
            EditWareHouseCmd model = _mapper.Map<EditWareHouseCmd>(dto);    

            return View(model);
        }


        [HttpPost]
        [Route("WareHouse/{SEOName}/Edit")]
        public async Task<IActionResult> Edit(string seoName, EditWareHouseCmd createWareHouseCmd)
            
        {
            createWareHouseCmd.SEOName = createWareHouseCmd.PalletRackName.ToLower().Replace(" ", "_") + "_" + createWareHouseCmd.PalletRackPosition.ToLower().Replace(" ", "_");

              if (!ModelState.IsValid)
                {
                    return View(createWareHouseCmd);
                }
            await _mediator.Send(createWareHouseCmd);
            return RedirectToAction(nameof(IndexWarehouse)); 
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateWareHouseCmd createWareHouseCmd)
            
        {
            createWareHouseCmd.SEOName = createWareHouseCmd.PalletRackName.ToLower().Replace(" ", "_") + "_" + createWareHouseCmd.PalletRackPosition.ToLower().Replace(" ", "_");

              if (!ModelState.IsValid)
                {
                    return View(createWareHouseCmd);
                }
            await _mediator.Send(createWareHouseCmd);
            return RedirectToAction(nameof(IndexWarehouse)); 
        }
    }
}

    


//tu nie tworzymy konstruktora tworzącego elementy do magazynu ponieważ jest to tylko controler View(prezentacji). Przenosimy logikę do warstwy App\Services\WarehauseServices

//Przyjmujemy formularz jako obiekt od użytkownika