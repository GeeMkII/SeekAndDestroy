using AutoMapper;
using MediatR;
using SAD.Domain.Interfaces;

namespace SAD.App.Warehouse.Queries.GetAllPlates
{
    internal class GetAllPlateQueryHandler : IRequestHandler<GetAllPlatesQuery, IEnumerable<WarehouseDto>>
    {
        private IWarehouseRepo _warehouseRepo;
        private IMapper _mapper;

        public GetAllPlateQueryHandler(IWarehouseRepo warehouseRepo, IMapper mapper)
        {
            _warehouseRepo = warehouseRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WarehouseDto>> Handle(GetAllPlatesQuery request, CancellationToken cancellationToken)
        {
            var warehouses = await _warehouseRepo.GetAll();
            var warehouseDtosMap = _mapper.Map<IEnumerable<WarehouseDto>>(warehouses);
            return warehouseDtosMap;
        }
    }
}
