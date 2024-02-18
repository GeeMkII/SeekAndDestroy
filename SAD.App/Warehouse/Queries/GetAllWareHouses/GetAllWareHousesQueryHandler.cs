using AutoMapper;
using MediatR;
using SAD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Warehouse.Queries.GetAllWareHouses
{
    internal class GetAllWareHousesQueryHandler : IRequestHandler<GetAllWareHousesQuery, IEnumerable<WarehouseDto>>
    {
        private readonly IWarehouseRepo _warehouseRepo;
        private readonly IMapper _mapper;

        public GetAllWareHousesQueryHandler( IWarehouseRepo warehouseRepo, IMapper mapper )
        {
            _warehouseRepo = warehouseRepo;
            _mapper = mapper;
        }
        public async Task<IEnumerable<WarehouseDto>> Handle(GetAllWareHousesQuery request, CancellationToken cancellationToken)
        {
            var warehouses = await _warehouseRepo.GetAll();
            var warehouseDtosMap = _mapper.Map<IEnumerable<WarehouseDto>>(warehouses);
            return warehouseDtosMap;
        }
    }
}
