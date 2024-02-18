﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Warehouse.Queries.GetAllWareHouses
{
    internal class GetAllWareHousesQuery : IRequest<IEnumerable<WarehouseDto>>
    {
    }
}
