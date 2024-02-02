using AutoMapper;
using MediatR;
using SAD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Warehouse.Comands.CretaPlates
{
    public class CreatePlateHandler : IRequestHandler<CreatePlatesCmd>
    {
        private IWarehouseRepo _warehouseRepo;
        private IMapper _mapper;

        public CreatePlateHandler(IWarehouseRepo warehouseRepo, IMapper mapper)
        {
            _warehouseRepo = warehouseRepo;
            _mapper = mapper;
        }
         public async Task<Unit> Handle(CreatePlatesCmd request, CancellationToken cancellationToken)
        {
            var warehouse = _mapper.Map<Domain.Entities.Warehouse>(request);
            warehouse.SeoName();
            await _warehouseRepo.Create(warehouse);
            return Unit.Value;
        }
    }
}
