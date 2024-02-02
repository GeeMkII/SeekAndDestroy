using AutoMapper;
using MediatR;
using SAD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Warehouse.Queries.GetAllPlates.GetById
{
    public class GetPlateByIdHandler : IRequestHandler<GetPlateById, WarehouseDto>
    {
        private readonly IWarehouseRepo _plateRepo;
        private readonly IMapper _mapper;

        public GetPlateByIdHandler(IWarehouseRepo plateRepo, IMapper mapper)
        {
           _plateRepo = plateRepo;
            _mapper = mapper;
        }

        public IMapper Mapper { get; }

        public async Task<WarehouseDto> Handle(GetPlateById request, CancellationToken cancellationToken)
        {
            var plate = await _plateRepo.GetById(request.PlateId);
            var dto = _mapper.Map<WarehouseDto>(plate);
            return dto;

        }
    }
}
