using AutoMapper;
using MediatR;
using SAD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Warehouse.Commands.CreateWareHouse
{
    internal class CreateWareHouseCmdHandler : IRequestHandler<CreateWareHouseCmd>
    {
        private readonly IWarehouseRepo _warehouseRepo;
        private readonly IMapper _mapper;

        public CreateWareHouseCmdHandler(IWarehouseRepo warehouseRepo, IMapper mapper)
        {
            _warehouseRepo = warehouseRepo;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateWareHouseCmd request, CancellationToken cancellationToken)
        {
            var warehouse = _mapper.Map<Domain.Entities.Warehouse>(request);
            warehouse.SeoName();

            await _warehouseRepo.Create(warehouse);

            return Unit.Value;
        }
    }
}
