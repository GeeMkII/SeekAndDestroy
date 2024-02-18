using AutoMapper;
using MediatR;
using SAD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Warehouse.Queries.GetWarHouseBySEO
{
    public class GetWarHouseBySeoQueryHandler : IRequestHandler<GetWarHouseBySeoQuery, WarehouseDto>
    {
        private readonly IWarehouseRepo _warehouseRepo;
        private readonly IMapper _mapper;

        public GetWarHouseBySeoQueryHandler(IWarehouseRepo warehouseRepo, IMapper mapper)
        {
            _warehouseRepo = warehouseRepo;
            _mapper = mapper;
        }

        public IWarehouseRepo WarehouseRepo { get; }

        public async Task<WarehouseDto> Handle(GetWarHouseBySeoQuery request, CancellationToken cancellationToken)
        {
            var wareHouse = await _warehouseRepo.GetBySeo(request.SeoName);
            var dto =  _mapper.Map<WarehouseDto>(wareHouse);
            return dto;
        }
    }
}
