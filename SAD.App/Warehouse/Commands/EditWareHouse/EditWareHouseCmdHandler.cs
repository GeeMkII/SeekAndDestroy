using MediatR;
using SAD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Warehouse.Commands.EditWareHouse
{
    public class EditWareHouseCmdHandler : IRequestHandler<EditWareHouseCmd>
    {
        private readonly IWarehouseRepo _warehouseRepo;

        public EditWareHouseCmdHandler(IWarehouseRepo warehouseRepo)
        {
            _warehouseRepo = warehouseRepo;
        }
        public async Task<Unit> Handle(EditWareHouseCmd request, CancellationToken cancellationToken)
        {
            var wareHouse = await _warehouseRepo.GetBySeo(request.SEOName!);


            wareHouse.Hardness = request.Hardness;
            wareHouse.Width= request.Width;
            wareHouse.Height = request.Height;
            wareHouse.Thickness= request.Thickness;
            
            wareHouse.PalletRack.Name = request.PalletRackName;
            wareHouse.PalletRack.Position = request.PalletRackPosition;

            wareHouse.Description= request.Description;

            _warehouseRepo.Commit();
            return Unit.Value;
        }
    }
}
