using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Warehouse.Queries.GetAllPlates.GetById
{
    public class GetPlateById : IRequest<WarehouseDto>
    {
        public int PlateId { get; set; }
        public GetPlateById(int plateId)
        {
            PlateId = plateId;
        }
    }
}
